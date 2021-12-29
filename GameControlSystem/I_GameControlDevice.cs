using System;
using System.Collections.Generic;

namespace dgtk.GameControlSystem
{
    internal interface I_GameControlDevice : IDisposable
    {
        uint ID {get;}
        string Name {get;}
        GameControlState State {get;}
        event EventHandler<dgtk_InputAxisEventArgs> EventAxis;
        event EventHandler<dgtk_InputHatsEventArgs> EventHats;
        event EventHandler<dgtk_InputButtonsEventArgs> EventButtons;
        //event EventHandler<dgtk_GameControllerStatusEventArgs> EventStatusChanged;
    }
}