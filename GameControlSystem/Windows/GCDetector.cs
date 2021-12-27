using System;
using System.Security;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dgtk.GameControlSystem.Windows
{
    internal static class GMSystem
    {
        internal static Dictionary<int, IntPtr> devicesKeys;
        internal static unsafe void RefreshDeviceList()
        {
            Console.WriteLine("Obteniendo Dispositivos de Windows:");
            if (devicesKeys == null) { devicesKeys = new Dictionary<int, IntPtr>(); }

            RAWINPUTDEVICELIST[] ridl; // Definimos array que contrndrá los diferentes dispositivos.

            uint n_rid = 0; //Variable que contendrá el numero de dispositivos detectados a obtener.

            if (Imports.GetRawInputDeviceList(null, ref n_rid, (uint)sizeof(RAWINPUTDEVICELIST)) >= 0) // Obtenemos el numero de dispositivos y si falla dicha obtención.
            {
                #if DEBUG
                    Console.WriteLine("Se han detectado " +n_rid + " Dispositivos.");
                #endif
            }
            else
            {
                #if DEBUG
                    Console.WriteLine("No s eha podido detectar el número de Dispositivos.");
                #endif
                return; //Salimos del método por el error. Pero no emitimos Excepción para poder continuar con la ejecución.
            }
            ridl = new RAWINPUTDEVICELIST[n_rid]; // Iniciamos el Array con el tamaño adecuado.
            if (Imports.GetRawInputDeviceList(ridl, ref n_rid, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST))) >= 0) // Obtenemos Los dispositivos y se vuelcan en el array.
            {
                #if DEBUG
                    Console.WriteLine("Se han obtenido los " + ridl.Length + " Dispositivos.");
                #endif
            }
            else
            {
                #if DEBUG
                    Console.WriteLine("No se han podido obtener los Dispositivos.");
                #endif
                return; //Salimos del método por el error. Pero no emitimos Excepción para poder continuar con la ejecución.
            }

            for (uint i=0;i<n_rid;i++) // Recorremos los dispositivos obtenidos.
            {
                #if DEBUG
                    //Console.WriteLine("Dispositivo "+i+": "+ridl[i].hDevice.ToString());
                #endif
                if (ridl[i].Type == RawInputDeviceType.HID) // ¿Es un Dispositivo de Interfaz Humana?
                {
                    AddInputDevice(ridl[i].hDevice);
                }            
            }
        }

        internal static void AddInputDevice(IntPtr dev)
        {
            GetDeviceName(dev);
            if (!dgtk.GameControlsManager.devices.ContainsKey(dev.ToInt32()))
            {
                DeviceInfo di; // Estructura que contiene la información del dispositivo a revisar.
                uint tam = (uint)Marshal.SizeOf(typeof(DeviceInfo)); // almacenamos el tamaño de la estructura dado que el metodo siguiente va con ref.

                if (Imports.GetRawInputDeviceInfo(dev, RawInputDeviceInfo_Command.RIDI_DEVICEINFO, out di, ref tam) > 0) // ¿Obtenemos info de dispositivo?
                {
                    #if DEBUG
                        //Console.WriteLine("La información de dispositivo ha sido obtenida.");
                    #endif                        
                }
                else
                {
                    #if DEBUG
                        //Console.WriteLine("No se han podido obtener la información de Dispositivo.");
                    #endif
                    return; // Cortamos ejecución del código.
                }
                if ((di.HIDInfo.UsagePage == (ushort)HIDUsagePage.Generic) && ((di.HIDInfo.Usage == (ushort)HIDUsage.Joystick) || (di.HIDInfo.Usage == (ushort)HIDUsage.Gamepad)))
                {
                    //Si el Dispositivo es un joystick o un GamePad lo añadimos, siempre y cuando no esté ya en la lista.
                    #if DEBUG
                        Console.WriteLine("Detectado Joystick o GamePad "+dev.ToInt32());
                    #endif
                    if (!devicesKeys.ContainsKey(dev.ToInt32())) // si el dispositivo no existia antes, lo añadimos.
                    {
                        byte[] PreparsedDeviceData = GetPreparsedData(dev); // Obtenemos Dytes de Datos del Dispositivo.
                        HIDP_CAPS HC = new HIDP_CAPS(); // Declaramos nueva Structura con las capacidades del dispositivo.
                        HIDResults HIDResult;
                        if ((HIDResult = Imports.HidP_GetCaps(PreparsedDeviceData, ref HC)) != HIDResults.HIDP_STATUS_SUCCESS)
                        {
                            #if DEBUG
                                Console.WriteLine("    Error al obtener Capacidades del dispositivo "+dev.ToInt32());
                                Console.WriteLine("        Result: "+HIDResult.ToString());
                            #endif
                            return; // Cortamos ejecución del código.
                        }

                        HIDP_VALUE_CAPS[] v_caps = new HIDP_VALUE_CAPS[HC.NumberInputValueCaps]; // Declaramos Array de Ejes y Hats.
                        if ((HIDResult = Imports.HidP_GetValueCaps(HIDP_REPORT_TYPE.HidP_Input, v_caps, ref HC.NumberInputValueCaps, PreparsedDeviceData)) != HIDResults.HIDP_STATUS_SUCCESS)
                        {
                            #if DEBUG
                                Console.WriteLine("    Error al obtener Ejes y Hats del dispositivo "+dev.ToString());
                                Console.WriteLine("        Result: "+HIDResult.ToString());
                            #endif
                            return; // Cortamos ejecución del código.
                        }
                        #if DEBUG
                            Console.WriteLine("    Obtenidos " + v_caps.Length + " Ejes o Hats en el dispositivo " +dev.ToString());
                        #endif

                        HIDP_BUTTON_CAPS[] b_caps = new HIDP_BUTTON_CAPS[HC.NumberInputButtonCaps]; // Declaramos Arra de Botones del dispositivo.
                        if ((HIDResult = Imports.HidP_GetButtonCaps(HIDP_REPORT_TYPE.HidP_Input, b_caps, ref HC.NumberInputButtonCaps, PreparsedDeviceData)) != HIDResults.HIDP_STATUS_SUCCESS)
                        {
                            #if DEBUG
                                Console.WriteLine("    Error al obtener Botones del dispositivo "+dev.ToString());
                            #endif
                            return; // Cortamos ejecución del código.
                        }
                        #if DEBUG
                            Console.WriteLine("    Obtenidos " + (b_caps[0].range.UsageMax - b_caps[0].range.UsageMin +1) + " Botones en el dispositivo " +dev.ToString());
                        #endif

                        GameControlDevice GCD_Temp = new GameControlDevice(dev, dev.ToInt32());

                        #if DEBUG
                        uint hats = 0;
                        uint Axis = 0;
                        #endif

                        for (int caps=0;caps<v_caps.Length;caps++)
                        {
                            if (v_caps[caps].notrange.Usage == HIDUsage.HatSwitch)
                            {
                                // Es un HAT.
                                #if DEBUG
                                hats++;
                                #endif

                                GCD_Temp.Hats.Add((uint)v_caps[caps].notrange.Usage, v_caps[caps]); // Añadimos Hat o D-PAD en posición Central.
                                GCD_Temp.HatsValues.Add((uint)v_caps[caps].notrange.Usage, (HatPosition) 8);
                                GCD_Temp.gameControlState_state.d_hats_values.Add((uint)v_caps[caps].notrange.Usage, (HatPosition) 8);
                            }
                            else
                            {
                                // ¿Es un Eje?
                                #if DEBUG
                                Axis++;
                                #endif

                                if (!GCD_Temp.Axis.ContainsKey((uint)v_caps[caps].notrange.Usage))
                                {
                                    GCD_Temp.Axis.Add((uint)v_caps[caps].notrange.Usage, v_caps[caps]); //Añadimos Eje.
                                    GCD_Temp.AxisValues.Add((uint)v_caps[caps].notrange.Usage, (long)((100f/(float)(v_caps[caps].LogicalMax-v_caps[caps].PhysicalMin))*50));
                                    GCD_Temp.gameControlState_state.d_axis_values.Add((uint)v_caps[caps].notrange.Usage, (int)((100f/(float)(v_caps[caps].LogicalMax-v_caps[caps].PhysicalMin))*50));
                                }
                            }
                        }

                        #if DEBUG
                            Console.WriteLine("Se han detectado " + Axis + "Ejes.");
                            Console.WriteLine("Se han detectado " + hats + "Hats.");
                        #endif

                        // Añadir Botones
                        //for (uint btns=0;btns<(b_caps[0].range.UsageMax - b_caps[0].range.UsageMin +1);btns++)
                        //{
                            #if DEBUG
                                //Console.WriteLine("Añadiendo Botón " + btns);
                            #endif
                            GCD_Temp.Btns.Add(0, b_caps[0]); // Añadimos botones
                            for (uint b=0;b<(b_caps[0].range.UsageMax - b_caps[0].range.UsageMin +1);b++)
                            {
                                GCD_Temp.BtnsValues.Add(b, false);
                                GCD_Temp.gameControlState_state.d_Buttons.Add(b, false);
                            }
                        //}

                        devicesKeys.Add(GCD_Temp.dev.ToInt32(), GCD_Temp.dev);
                        dgtk.GameControlsManager.devices.Add(GCD_Temp.dev.ToInt32(), new dgtk_GameControler(GCD_Temp)); // Añadimos GameControl a la lista.
                    }
                }
            }
        }

        internal static unsafe string GetDeviceName(IntPtr dev)
        {
            uint n_size = 0;
            IntPtr ptr = IntPtr.Zero;
            if (Imports.GetRawInputDeviceInfo(dev, RawInputDeviceInfo_Command.RIDI_DEVICENAME, ptr, ref n_size) >= 0) // ¿Obtenemos info de dispositivo?
            {
                ptr = Marshal.AllocHGlobal(((int)n_size)*2);
                if (Imports.GetRawInputDeviceInfo(dev, RawInputDeviceInfo_Command.RIDI_DEVICENAME, ptr, ref n_size) > 0) // ¿Obtenemos info de dispositivo?
                {
                    Console.WriteLine(Marshal.PtrToStringAuto(ptr));
                    return Marshal.PtrToStringAuto((ptr));
                }
                #if DEBUG
                    //Console.WriteLine("Nombre: "+new string(nombre));
                #endif                        
            }
            /*
            ulong tam = 0;
            //Imports.HidD_GetProductString(dev, null, tam);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            IntPtr ptr_name = Marshal.AllocHGlobal(sizeof(bytes)*127);
            if (Imports.HidD_GetProductString(dev, ptr_name, 126))
            {
                Console.WriteLine("NAME: "+Marshal.PtrToStringBSTR(ptr_name));
            }*/
            return "";
        }

        internal static void RemovedInputDeviceList()
        {
            RAWINPUTDEVICELIST[] ridl; // Definimos array que contrndrá los diferentes dispositivos.

            uint n_rid = 0; //Variable que contendrá el numero de dispositivos detectados a obtener.

            if (Imports.GetRawInputDeviceList(null, ref n_rid, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST))) < 0) // Obtenemos el numero de dispositivos y si falla dicha obtención.
            {
                return; //Salimos del método por el error. Pero no emitimos Excepción para poder continuar con la ejecución.
            }
            ridl = new RAWINPUTDEVICELIST[n_rid]; // Iniciamos el Array con el tamaño adecuado.
            if (Imports.GetRawInputDeviceList(ridl, ref n_rid, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST))) < 0) // Obtenemos Los dispositivos y se vuelcan en el array.
            {
                return; //Salimos del método por el error. Pero no emitimos Excepción para poder continuar con la ejecución.
            }

            foreach(int key in devicesKeys.Keys)
            {
                bool removed = true;
                for (uint i=0;i<n_rid;i++)
                {
                    if (key == ridl[i].hDevice.ToInt32())
                    {
                        removed = false;
                    }
                }
                if (removed)
                {
                    // Remover.
                    devicesKeys.Remove(key);
                    dgtk.GameControlsManager.devices.Remove(key);
                }
            }
        }

        internal static void RemoveInputDevice(IntPtr dev)
        {
            if (dgtk.GameControlsManager.devices.ContainsKey(dev.ToInt32()))
            {
                dgtk.GameControlsManager.devices[dev.ToInt32()].Dispose();
                dgtk.GameControlsManager.devices.Remove(dev.ToInt32());
            }
        }

        internal static byte[] GetPreparsedData(IntPtr device) // Obtenemos Dytes de Datos del Dispositivo.
        {
            int PreparsedSize = 0;
            int result;
            if ((result = Imports.GetRawInputDeviceInfo(device, RawInputDeviceInfo_Command.RIDI_PREPARSEDDATA, IntPtr.Zero, ref PreparsedSize)) >= 0) // ¿Obtenemos info de dispositivo?
            {
                #if DEBUG
                    //Console.WriteLine("    Obtenidos " + PreparsedSize + " bytes de Datos de dispositivo "+device.ToString());
                    //Console.WriteLine("        Result: "+result);
                #endif
            }
            else
            {
                #if DEBUG
                    //Console.WriteLine("    Fallo en obtención de tamaño de Datos de dispositivo "+device.ToString());
                    //Console.WriteLine("        Result: "+result);
                #endif
                return null;
            }

            byte[] preparsed_data = new byte[PreparsedSize];
            //int result;
            if ((result = Imports.GetRawInputDeviceInfo(device, RawInputDeviceInfo_Command.RIDI_PREPARSEDDATA, preparsed_data, ref PreparsedSize)) > 0)
            {
                #if DEBUG
                    //Console.WriteLine("    Preparsed Data Obtenido del dispositivo "+device.ToString());
                    //Console.WriteLine("        Result: "+result);
                #endif
                return preparsed_data;
            }
            else
            {
                #if DEBUG
                    //Console.WriteLine("    Fallo en obtención de Preparsed Data del dispositivo "+device.ToString());
                    //Console.WriteLine("        Result: "+result);
                #endif
                return null;
            }
        }
    
        internal static unsafe void SetGameControlDevice_Status(dgtk.Platforms.Win32.RawInput ri)
        {
            GameControlDevice GCD_Event = (GameControlDevice)dgtk.GameControlsManager.devices[ri.Header.hDevice.ToInt32()].device;

            /*if (Imports.HidP_GetUsageValue(HIDP_REPORT_TYPE.HidP_Input, joystick.v_caps[i].UsagePage, 0, (HIDUsage)(joystick.v_caps[i].notrange.Usage), ref value, pre_data, new IntPtr((void*)&ri.Data.HID.Data), ri.Data.HID.Size) != HIDResults.HIDP_STATUS_SUCCESS)
            {

            }*/
            byte[] pre_data = GetPreparsedData(ri.Header.hDevice);
            
            #region Ejes:
            
            foreach (uint key in GCD_Event.Axis.Keys)
            {
                long value = 0;
                if (Imports.HidP_GetUsageValue(HIDP_REPORT_TYPE.HidP_Input, GCD_Event.Axis[key].UsagePage, 0, (HIDUsage)(GCD_Event.Axis[key].notrange.Usage), ref value, pre_data, new IntPtr((void*)&ri.Data.HID.Data), ri.Data.HID.Size) == HIDResults.HIDP_STATUS_SUCCESS)
                {
                    // Ejes
                    long percent = 0;
                    if(GCD_Event.Axis[key].BitSize == 8)
                    {
                        percent = (long)((100f/(GCD_Event.Axis[key].LogicalMax-GCD_Event.Axis[key].PhysicalMin))*value);
                    }
                    else
                    {
                        percent = (long)((100f/ushort.MaxValue)*(value));
                    }
                    if (GCD_Event.AxisValues[key] != percent) // Solo lanzar evento si valor cambia.
                    {
                        GCD_Event.AxisValues[key] = percent;
                        GCD_Event.LanzarEventAxis(dgtk.GameControlsManager.devices[ri.Header.hDevice.ToInt32()], new dgtk_InputAxisEventArgs(ri.Header.hDevice.ToInt32(), (int)key, (int)percent, GCD_Event.gameControlState_state));
                    }
                }
            }

            #endregion

            #region Hats

            foreach (uint key in GCD_Event.Hats.Keys)
            {
                long value = 0;
                if (Imports.HidP_GetUsageValue(HIDP_REPORT_TYPE.HidP_Input, GCD_Event.Hats[key].UsagePage, 0, (HIDUsage)(GCD_Event.Hats[key].notrange.Usage), ref value, pre_data, new IntPtr((void*)&ri.Data.HID.Data), ri.Data.HID.Size) == HIDResults.HIDP_STATUS_SUCCESS)
                {
                    // Hats
                    if (GCD_Event.HatsValues[key] != (HatPosition)value)
                    {
                        GCD_Event.HatsValues[key] = (HatPosition)value;
                        GCD_Event.LanzarEventHats(dgtk.GameControlsManager.devices[ri.Header.hDevice.ToInt32()], new dgtk_InputHatsEventArgs(ri.Header.hDevice.ToInt32(), (int)key, GCD_Event.HatsValues[key], GCD_Event.gameControlState_state));
                    }
                }
            }

            #endregion
            
            #region Botones:

            int n_estados = GCD_Event.BtnsValues.Count; // Este valor cambiará
            short* ptr_usageButtons = stackalloc short[n_estados]; // Ids Botones Presionados.
            if (Imports.HidP_GetUsages(HIDP_REPORT_TYPE.HidP_Input, GCD_Event.Btns[0].UsagePage, 0, ptr_usageButtons, ref n_estados, pre_data, new IntPtr((void*)&ri.Data.HID.Data), ri.Data.HID.Size) == HIDResults.HIDP_STATUS_SUCCESS)
            {
                //Console.WriteLine("Nº Valores Estados: "+n_estados+" de "+GCD_Event.BtnsValues.Count);
                //Console.WriteLine("Size: "+ri.Data.HID.Size);
                for (int b=0;b<GCD_Event.BtnsValues.Count;b++) // Recorremos todos los botones del mando.
                {
                    bool b_value = false;
                    for (int n=0;n<n_estados;n++) // Recorremos botones obtenidos pulsados
                    {
                        if (b == (ptr_usageButtons[n]-1))
                        {
                            b_value = true;
                        }
                    }
                    
                    //Console.WriteLine("BTN_DEBUG: "+b+" -> "+b_value);
                    if (b_value != GCD_Event.BtnsValues[(uint)b])
                    {
                        GCD_Event.BtnsValues[(uint)b] = b_value;
                        // Lanzamos Evento.
                        GCD_Event.LanzarEventBTNs(dgtk.GameControlsManager.devices[ri.Header.hDevice.ToInt32()], new dgtk_InputButtonsEventArgs(ri.Header.hDevice.ToInt32(), (int)b, GCD_Event.BtnsValues[(uint)b], GCD_Event.gameControlState_state));
                    }
                }
            }
            else
            {
                Console.WriteLine("FALLA!!!!");
            }

            #endregion

            // AL FINAL LANZAR STATUS.
        }
    }
}