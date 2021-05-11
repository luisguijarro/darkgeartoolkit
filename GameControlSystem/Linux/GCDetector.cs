using System;
using System.IO;
using System.Collections.Generic;

namespace dgtk.GameControlSystem.Linux
{
    internal static class GMSystem
    {
        internal static Dictionary<string, int> devicesKeys;
        public static unsafe void RefreshDeviceList()
        {
            if (devicesKeys == null) { devicesKeys = new Dictionary<string, int>(); } //Iniciamos diccionario
            string[] eventFiles = Directory.GetFiles("/dev/input/by-id", "*-event-joystick"); //Recojemos todos los ficheros de eventos de joysticks.
            
            #region UNPLUG:

            string[] s_keys = new string[devicesKeys.Count];
            devicesKeys.Keys.CopyTo(s_keys, 0);
            List<string> Keys = new List<string>(s_keys);
            foreach (string key in Keys)
            {
                bool b_unpluged = true;
                for (int i=0;i<eventFiles.Length;i++)
                {
                    if (key == eventFiles[i])
                    {
                        b_unpluged = false;
                    }
                }
                if (b_unpluged)
                {
                    dgtk.GameControlsManager.devices[devicesKeys[key]].Dispose();
                    dgtk.GameControlsManager.devices.Remove(devicesKeys[key]);
                    #if DEBUG
                        Console.WriteLine("Unpluged: "+devicesKeys[key]);
                    #endif
                    devicesKeys.Remove(key);
                    //System.GC.Collect(); // Intenando que file.Dispose() tenga más efecto. Sin resultado.
                }
            }

            #endregion
            
            for (int d=0;d<eventFiles.Length;d++)
            {
                if (!devicesKeys.ContainsKey(eventFiles[d])) // Si no figura en la lista leemos.
                {
                    //System.Threading.Thread.Sleep(1000);
                    //FileStream file = File.Open(eventFiles[d], FileMode.Open, FileAccess.ReadWrite, (FileShare.ReadWrite | FileShare.Delete)); //Abrimos el archivo.
                    //int DevidefileId = file.SafeFileHandle.DangerousGetHandle().ToInt32(); //Obtenemos el id equivalente de open de Lenguaje C.
                    
                    int DevidefileId = Imports.open(eventFiles[d], 4); // Obteniendo filedescriptor desde libc.

                    IntPtr dev = new IntPtr();
                    if (Imports.libevdev_new_from_fd(DevidefileId, &dev) >= 0) // Obtenemos el dispositivo. ¿Todo va bien?
                    {
                        //GameControlDevice GCD_Temp = new GameControlDevice(dev, file);
                        GameControlDevice GCD_Temp = new GameControlDevice(dev, DevidefileId);

                        string id = Imports.libevdev_get_uniq(dev); //Obtenemos identificador único del dispositivo. No se obtiene nada.
                        #if DEBUG
                            Console.WriteLine("ID: "+id);
                        #endif
    
                        if (id.Length <= 0) // ¿Exixte identificador único?
                        {
                            //id = eventFiles[d]; // Por si no existe identificador único, cosa que parece lo más probable.
                        }

                        GCD_Temp.id = DevidefileId; // Empleamos el identificador del fichero como ID de dispositivo.
                        //GCD_Temp.id = id;

                        //if (!dgtk.GameControlsManager.devices.ContainsKey(id)) //Si el dispositivo no ha sido detectado antes.
                        //{
                            bool hasAxis = false; // ABS Y REL 
                            bool hasButtonsOrKeys = false; // Botones o Teclas EV_KEYS
                            bool hasFF = false; // Bibración y demáses.
                            bool hasLED = false; // Bibración y demáses.
                            
                            //GameControlDevice tempdevice = new GameControlDevice(dev); //Creamos nuevo dispositivo.
                            GCD_Temp.s_name = Imports.libevdev_get_name(dev); //Obtenemos Nombre del Dispositivo.
                            #if DEBUG
                                Console.WriteLine(GCD_Temp.Name);
                            #endif
                            foreach(GameControlEventType value in Enum.GetValues(typeof(GameControlEventType))) // Recorremos los tipos de Eventos.
                            {
                                if (Imports.libevdev_has_event_type(dev, (GameControlEventType)value) == 1) //¿Soporta este tipo de evento?
                                {
                                    #if DEBUG
                                        Console.WriteLine(((GameControlEventType)value).ToString());
                                    #endif
                                    switch((GameControlEventType)value)
                                    {
                                        case GameControlEventType.EV_ABS:
                                        case GameControlEventType.EV_REL:
                                            hasAxis = true;
                                            break;
                                        case GameControlEventType.EV_KEY:
                                            hasButtonsOrKeys = true;
                                            break;
                                        case GameControlEventType.EV_FF:
                                            hasFF = true;
                                            break;
                                        case GameControlEventType.EV_LED:
                                            hasLED = true;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }

                            if (hasAxis) //Si tiene Ejes...
                            {
                                List<GameControlABS_EventCode> HatCol = new List<GameControlABS_EventCode>() //Definimos cuales son HAT
                                {
                                    GameControlABS_EventCode.ABS_HAT0X,
                                    GameControlABS_EventCode.ABS_HAT0Y,
                                    GameControlABS_EventCode.ABS_HAT1X,
                                    GameControlABS_EventCode.ABS_HAT1Y,
                                    GameControlABS_EventCode.ABS_HAT2X,
                                    GameControlABS_EventCode.ABS_HAT2Y,
                                    GameControlABS_EventCode.ABS_HAT3X,
                                    GameControlABS_EventCode.ABS_HAT3Y,
                                };
                                foreach ( GameControlABS_EventCode value in Enum.GetValues(typeof(GameControlABS_EventCode)))
                                {
                                    if (Imports.libevdev_has_event_code(dev, GameControlEventType.EV_ABS, (uint)value) == 1) //¿Soporta EJES?
                                    {
                                        if (HatCol.Contains(value)) //Si es un HAT..
                                        {
                                            // AÑADIR A HATS
                                            GCD_Temp.Hats.Add((uint)value, 0);
                                            GCD_Temp.gameControlState_state.d_hats_values.Add((uint)value, (HatPosition)8);
                                        }
                                        else //Si no es un HAT es un Eje.
                                        {
                                            // AÑADIR A EJES
                                            int min = Imports.libevdev_get_abs_minimum(dev, (uint)value);
                                            int max = Imports.libevdev_get_abs_maximum(dev, (uint)value);
                                            GCD_Temp.Axis.Add((uint)value, new Axis((uint)value, max, min));
                                            GCD_Temp.gameControlState_state.d_axis_values.Add((uint)value, 50);
                                        }
                                        #if DEBUG
                                            //Console.WriteLine(value.ToString());
                                        #endif
                                    }
                                }
                            }
                            if (hasButtonsOrKeys) // ¿Tiene botones o teclas?
                            {
                                foreach ( GameControlBTN_EventCode value in Enum.GetValues(typeof(GameControlBTN_EventCode)))
                                {
                                    if (Imports.libevdev_has_event_code(dev, GameControlEventType.EV_KEY, (uint)value) == 1) //¿Soporta TECLAS o BOTONES?
                                    {
                                        // AÑADIR A BOTONES
                                        if (!GCD_Temp.Btns.ContainsKey((uint)value)) 
                                        {
                                            GCD_Temp.Btns.Add((uint)value, false);
                                            GCD_Temp.gameControlState_state.d_Buttons.Add((uint)value, false);
                                        }
                                        #if DEBUG
                                            //Console.WriteLine(value.ToString());
                                        #endif
                                    }
                                }
                            }
                            if (hasFF) // ¿Tiene Retorno de Fuerza?
                            {
                                // En obras!!!
                            }
                            if (hasLED)
                            {
                                // En obras!!!
                            }
                            dgtk.GameControlsManager.devices.Add(GCD_Temp.id, new dgtk_GameControler(GCD_Temp));
                            devicesKeys.Add(eventFiles[d], GCD_Temp.id);
                        //}
                    }
                    else
                    {
                        //ERROR!!!
                        Imports.close(DevidefileId); // Cerramos archivo inecesario.
                    }  
                }      
            }
        }
    }
}