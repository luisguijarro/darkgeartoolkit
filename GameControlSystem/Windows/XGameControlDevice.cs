/*
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace dgtk.GameControlSystem.Windows
{       
    internal class XGameControlDevice : dgtk.GameControlSystem.I_GameControlDevice
    {
        internal uint id;   
        internal readonly string s_name;  
        internal readonly GameControlState gameControlState_state;
        private uint dwPacketNumber;

        internal Thread hilo;
        internal bool disposed;

        internal XINPUT_GAMEPAD XI_GAMEPAD;
        internal XINPUT_VIBRATION XI_VIBRATION;
        public event EventHandler<dgtk_InputAxisEventArgs> EventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> EventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> EventButtons; // Evento de accionamiento de Botones.

        public XGameControlDevice(uint in_id, XINPUT_CAPABILITIES XIcap)
        {
            this.id = in_id;
            this.s_name = "Game Pad "+in_id.ToString();
            this.XI_GAMEPAD = XIcap.Gamepad;
            this.XI_VIBRATION = XIcap.Vibration;

            this.gameControlState_state = new GameControlState();
            this.gameControlState_state.d_axis_values = new Dictionary<uint, int>();
            for (uint i=0;i<6;i++)
            {
                this.gameControlState_state.d_axis_values.Add(i, 0);
            }            
            this.gameControlState_state.d_Buttons = new Dictionary<uint, bool>();
            foreach(ushort btn in Enum.GetValues(typeof(wButtons)))
            {
                this.gameControlState_state.d_Buttons.Add(btn, false);
            }           
            this.gameControlState_state.d_hats_values = new Dictionary<uint, HatPosition>();
            

            this.EventAxis += this.InputAxisEvent;
            this.EventHats += this.InputHatsEvent;
            this.EventButtons += this.InputBTNsEvent;

            this.hilo = new Thread(new ThreadStart(this.ProcessEvents)); // Definir hilo procesador de eventos.
            this.hilo.Start(); // Iniciar hilo de procesamiento de eventos.
        }

        internal void ProcessEvents()
        {
            XINPUT_STATE XI_STATE = new XINPUT_STATE();
            while(!disposed)
            {
                
                if (Imports.XInputGetState(this.id, ref XI_STATE) == XInputResult.SUCCESS)
                {                   
                    if (this.dwPacketNumber != XI_STATE.dwPacketNumber) // Si es diferente hay cambio de estado y por tanto evento. Cambia aun si que pase nada.
                    {
                        this.dwPacketNumber = XI_STATE.dwPacketNumber;
                        //Console.WriteLine( XI_STATE.dwPacketNumber); // Cambia aun si que pase nada.

                        //EJES:
                        if(XI_STATE.Gamepad.sThumbLX != XI_GAMEPAD.sThumbLX)
                        {
                            int val = 50;
                            if (XI_STATE.Gamepad.sThumbLX > (int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbLX-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE));
                            }
                            if (XI_STATE.Gamepad.sThumbLX < 0-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+XI_STATE.Gamepad.sThumbLX));
                            }
                            
                            #if DEBUG
                                Console.WriteLine("sThumbLX: "+XI_STATE.Gamepad.sThumbLX);
                                Console.WriteLine("  -LX: "+val);
                                Console.WriteLine("  -Another: "+((XI_STATE.Gamepad.sThumbLX+0.5f)/32767.5f).ToString());
                            #endif

                            this.gameControlState_state.d_axis_values[0] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 0, val, this.gameControlState_state));
                        }
                        if (XI_STATE.Gamepad.sThumbLY != XI_GAMEPAD.sThumbLY)
                        {
                            int val = 50;
                            if (XI_STATE.Gamepad.sThumbLY > (int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbLY-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE));
                            }
                            if (XI_STATE.Gamepad.sThumbLY < 0-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbLY));
                            }
                            
                            #if DEBUG
                                Console.WriteLine("sThumbLY: "+XI_STATE.Gamepad.sThumbLY);
                                Console.WriteLine("  -LY: "+val);
                            #endif

                            this.gameControlState_state.d_axis_values[1] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 1, val, this.gameControlState_state));
                        }

                        if (XI_STATE.Gamepad.sThumbRX != XI_GAMEPAD.sThumbRX)
                        {
                            int val = 50;
                            if (XI_STATE.Gamepad.sThumbRX > (int)DefinedDeadZones.XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbRX-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE));
                            }
                            if (XI_STATE.Gamepad.sThumbRX < 0-(int)DefinedDeadZones.XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbRX));
                            }

                            #if DEBUG
                                Console.WriteLine("sThumbRX: "+XI_STATE.Gamepad.sThumbRX);
                                Console.WriteLine("  -RX: "+val);
                            #endif

                            this.gameControlState_state.d_axis_values[2] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 2, val, this.gameControlState_state));
                        }
                        if (XI_STATE.Gamepad.sThumbRY != XI_GAMEPAD.sThumbRY)
                        {
                            int val = 50;
                            if (XI_STATE.Gamepad.sThumbRY > (int)DefinedDeadZones.XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbRY-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE));
                            }
                            if (XI_STATE.Gamepad.sThumbRY < 0-(int)DefinedDeadZones.XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE)
                            {
                                val = (int)((100f/(ushort.MaxValue-(int)DefinedDeadZones.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE))*(short.MaxValue+1+XI_STATE.Gamepad.sThumbRY));
                            }
                            
                            #if DEBUG
                                Console.WriteLine("sThumbRY: "+XI_STATE.Gamepad.sThumbRY);
                                Console.WriteLine("  -RY: "+val);
                            #endif
                            this.gameControlState_state.d_axis_values[3] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 3, val, this.gameControlState_state));
                        }

                        float maxValueT = 255-(int)DefinedDeadZones.XINPUT_GAMEPAD_TRIGGER_THRESHOLD;

                        if (XI_STATE.Gamepad.bLeftTrigger != XI_GAMEPAD.bLeftTrigger)
                        {
                            int val = (int)((100f/maxValueT)*XI_STATE.Gamepad.bLeftTrigger<30 ? 0 : XI_STATE.Gamepad.bLeftTrigger + 30);
                            #if DEBUG
                                Console.WriteLine("bLeftTrigger: "+XI_STATE.Gamepad.bLeftTrigger);
                                Console.WriteLine("  -LT: "+val);
                            #endif
                            this.gameControlState_state.d_axis_values[4] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 4, val, this.gameControlState_state));
                        }
                        if (XI_STATE.Gamepad.bRightTrigger != XI_GAMEPAD.bRightTrigger)
                        {
                            int val = (int)((100f/maxValueT)*(XI_STATE.Gamepad.bRightTrigger<30 ? 0 : XI_STATE.Gamepad.bRightTrigger + 30));
                            #if DEBUG
                                Console.WriteLine("bRightTrigger: "+XI_STATE.Gamepad.bRightTrigger);
                                Console.WriteLine("  -RT: "+val);
                            #endif
                            this.gameControlState_state.d_axis_values[5] = val;
                            LanzarEventAxis(this, new dgtk_InputAxisEventArgs(this.id, 5, val, this.gameControlState_state));
                        }

                        //BOTONES:
                        if (XI_STATE.Gamepad.wButtons != XI_GAMEPAD.wButtons) // hay cambios en los botones?
                        {
                            foreach(ushort btn in Enum.GetValues(typeof(wButtons)))
                            {
                                bool btn_before = ((((ushort)XI_GAMEPAD.wButtons) & btn) == btn);
                                bool btn_now = ((((ushort)XI_STATE.Gamepad.wButtons) & btn) == btn);
                                if (btn_before != btn_now)
                                {
                                    LanzarEventBTNs(this, new dgtk_InputButtonsEventArgs(this.id, (int)btn, btn_now, this.gameControlState_state));
                                }
                            }
                        }
                        XI_GAMEPAD = XI_STATE.Gamepad; // Actualizamos Estado del GamePad.
                    }
                    
                }
                Thread.Sleep(100);  // Descargamos carga de CPU.
            }            
        }

        public void Dispose()
        {
            this.disposed = true;
            this.EventAxis -= this.InputAxisEvent;
            this.EventHats -= this.InputHatsEvent;
            this.EventButtons -= this.InputBTNsEvent;
        }

        #region Events:

        internal void LanzarEventAxis(object sender, dgtk_InputAxisEventArgs e)
        {
            this.EventAxis(sender, e);
        }
        internal void LanzarEventHats(object sender, dgtk_InputHatsEventArgs e)
        {
            this.gameControlState_state.d_hats_values[(uint)e.Hat] = e.Value;
            this.EventHats(sender, e);
        }
        internal void LanzarEventBTNs(object sender, dgtk_InputButtonsEventArgs e)
        {
            this.gameControlState_state.d_Buttons[(uint)e.Button] = e.Pressed;
            this.EventButtons(sender, e);
        }

        private void InputAxisEvent(object sender, dgtk_InputAxisEventArgs e)
        {
            if ( Core.windows != null)
            {
                foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
                {
                    win.LaunchEventAxis(sender, e); // LLamar Lanzamiento de eventos en ventana.
                }
            }
        }

        private void InputHatsEvent(object sender, dgtk_InputHatsEventArgs e)
        {
            if ( Core.windows != null)
            {
                foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
                {
                    win.LaunchEventHats(sender, e); // LLamar Lanzamiento de eventos en ventana.
                }
            }
        }

        private void InputBTNsEvent(object sender, dgtk_InputButtonsEventArgs e)
        {
            if ( Core.windows != null)
            {
                foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
                {
                    win.LaunchEventBTNs(sender, e); // LLamar Lanzamiento de eventos en ventana.
                }
            }
        }

        #endregion

        public uint ID
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.s_name; }
        }

        public GameControlState State
        {
            get { return this.gameControlState_state; }
        }

    }
}
*/