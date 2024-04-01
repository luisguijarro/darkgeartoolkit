using System;

namespace dgtk
{
    internal static class EventsTools
    {
        #region Windows
		public static KeyCode Winkey(Int64 lParam)
		{
			KeyCode KeyRet = KeyCode.Unknown;
			short scancode = (short)((lParam >> 16) & 255); //Cogemos los 8 bits (255 = 11111111) a partir del bit 16
			switch(scancode)
			{
				case 0:
					KeyRet = KeyCode.Unknown;
					break;
				
				#region System Keys:
				case 1:
					KeyRet = KeyCode.ESC;
					break;
				case 14:
					KeyRet = KeyCode.BackSpace;
					break;
				case 15:
					KeyRet = KeyCode.Tab;
					break;
				case 28:
					KeyRet = KeyCode.Intro;
					break;
				case 58:
					KeyRet = KeyCode.CapsLock;
					break;
				case 42:
					KeyRet = KeyCode.Shift_Left;
					break;
				case 54:
					KeyRet = KeyCode.Shift_Right;
					break;
				case 29:
					KeyRet = KeyCode.Control_Left;
					break;
				//case 29:  //Extended
				//	KeyRet = KeyCode.Control_Right;
				//	break;
				case 56:
					KeyRet = KeyCode.Alt;
					break;
				case 57:
					KeyRet = KeyCode.Space;
					break;
				case 70:
					KeyRet = KeyCode.Scroll;
					break;
				case 69:
					KeyRet = KeyCode.Pause;
					break;
				
				case 91:
					KeyRet = KeyCode.Win_Left;
					break;
				case 92:
					KeyRet = KeyCode.Win_Right;
					break;
				#endregion
					
				#region Números:
				case 2:
					KeyRet = KeyCode.number1;
					break;
				case 3:
					KeyRet = KeyCode.number2;
					break;
				case 4:
					KeyRet = KeyCode.number3;
					break;
				case 5:
					KeyRet = KeyCode.number4;
					break;
				case 6:
					KeyRet = KeyCode.number5;
					break;
				case 7:
					KeyRet = KeyCode.number6;
					break;
				case 8:
					KeyRet = KeyCode.number7;
					break;
				case 9:
					KeyRet = KeyCode.number8;
					break;
				case 10:
					KeyRet = KeyCode.number9;
					break;
				case 11:
					KeyRet = KeyCode.number0;
					break;
					
				
				case 79:
					KeyRet = KeyCode.numberPad1;
					break;
				case 80:
					KeyRet = KeyCode.numberPad2;
					break;
				case 81:
					KeyRet = KeyCode.numberPad3;
					break;
				case 75:
					KeyRet = KeyCode.numberPad4;
					break;
				case 76:
					KeyRet = KeyCode.numberPad5;
					break;
				case 77:
					KeyRet = KeyCode.numberPad6;
					break;
				case 71:
					KeyRet = KeyCode.numberPad7;
					break;
				case 72:
					KeyRet = KeyCode.numberPad8;
					break;
				case 73:
					KeyRet = KeyCode.numberPad9;
					break;
				case 82:
					KeyRet = KeyCode.numberPad0;
					break;
				#endregion
					
				#region Math:
				case 12:
					KeyRet = KeyCode.Minus;
					break;
				case 13:
					KeyRet = KeyCode.Plus;
					break;
				case 55:
					KeyRet = KeyCode.Multiply;
					break;
				//case 53: //(EXTENDED)
				//	KeyRet = KeyCode.Divide;
				//	break;
				case 26:
					KeyRet = KeyCode.Bracket_Left;
					break;
				case 27:
					KeyRet = KeyCode.Braket_Right;
					break;
				case 86:
					KeyRet = KeyCode.Less;
					break;
				#endregion
					
				#region Function Keys:
				case 59:
					KeyRet = KeyCode.F1;
					break;
				case 60:
					KeyRet = KeyCode.F2;
					break;
				case 61:
					KeyRet = KeyCode.F3;
					break;
				case 62:
					KeyRet = KeyCode.F4;
					break;
				case 63:
					KeyRet = KeyCode.F5;
					break;
				case 64:
					KeyRet = KeyCode.F6;
					break;
				case 65:
					KeyRet = KeyCode.F7;
					break;
				case 66:
					KeyRet = KeyCode.F8;
					break;
				case 67:
					KeyRet = KeyCode.F9;
					break;
				case 68:
					KeyRet = KeyCode.F10;
					break;
				case 87:
					KeyRet = KeyCode.F11;
					break;
				case 88:
					KeyRet = KeyCode.F12;
					break;
				#endregion
									
				#region Letras (sin ñ):
				case 30:
					KeyRet = KeyCode.a;
					break;
				case 48:
					KeyRet = KeyCode.b;
					break;
				case 46:
					KeyRet = KeyCode.c;
					break;
				case 32:
					KeyRet = KeyCode.d;
					break;
				case 18:
					KeyRet = KeyCode.e;
					break;
				case 33:
					KeyRet = KeyCode.f;
					break;
				case 34:
					KeyRet = KeyCode.g;
					break;
				case 35:
					KeyRet = KeyCode.h;
					break;
				case 23:
					KeyRet = KeyCode.i;
					break;
				case 36:
					KeyRet = KeyCode.j;
					break;
				case 37:
					KeyRet = KeyCode.k;
					break;
				case 38:
					KeyRet = KeyCode.l;
					break;
				case 50:
					KeyRet = KeyCode.m;
					break;
				case 49:
					KeyRet = KeyCode.n;
					break;
				//case 30:
				//	KeyRet = KeyCode.ñ;
				//	break;
				case 24:
					KeyRet = KeyCode.o;
					break;
				case 25:
					KeyRet = KeyCode.p;
					break;
				case 16:
					KeyRet = KeyCode.q;
					break;
				case 19:
					KeyRet = KeyCode.r;
					break;
				case 31:
					KeyRet = KeyCode.s;
					break;
				case 20:
					KeyRet = KeyCode.t;
					break;
				case 22:
					KeyRet = KeyCode.u;
					break;
				case 47:
					KeyRet = KeyCode.v;
					break;
				case 17:
					KeyRet = KeyCode.w;
					break;
				case 45:
					KeyRet = KeyCode.x;
					break;
				case 21:
					KeyRet = KeyCode.y;
					break;
				case 44:
					KeyRet = KeyCode.z;
					break;
				#endregion
				
				#region Simbolos:
				case 39:
					KeyRet = KeyCode.SemiColon;
					break;
				case 40:
					KeyRet = KeyCode.Quote;
					break;
				case 41:
					KeyRet = KeyCode.Grave_Accent;
					break;
				case 43:
					KeyRet = KeyCode.BackSlash;
					break;
				case 51:
					KeyRet = KeyCode.Comma;
					break;
				case 52:
					KeyRet = KeyCode.Period;
					break;
				case 53:
					KeyRet = KeyCode.Slash;
					break;
				#endregion
				
				default:					
					KeyRet = KeyCode.Unknown;
					break;
			}
			//Console.WriteLine("SCANCODE: "+scancode);
			//Console.WriteLine("KeyCode: "+KeyRet);
			
			if ((lParam & ( 1<<24)) != 0) // Si el Bit 25 empezando por la derecha de lParam es diferente a cero... Extendido
			{
				//Console.WriteLine("Extended");
				switch(scancode)
				{
					case 69:
						KeyRet = KeyCode.NumLock;
						break;
					#region Arrows:
					case 72:
						KeyRet = KeyCode.UP;
						break;
					case 80:
						KeyRet = KeyCode.DOWN;
						break;
					case 75:
						KeyRet = KeyCode.LEFT;
						break;
					case 77:
						KeyRet = KeyCode.RIGHT;
						break;
					#endregion
					
					#region System Keys Extended
					case 29:
						KeyRet = KeyCode.Control_Right;
						break;
					case 55:
						KeyRet = KeyCode.PrintScreen;
						break;
					case 56:
						KeyRet = KeyCode.AltGr;
						break;
					case 71:
						KeyRet = KeyCode.Home;
						break;
					case 79:
						KeyRet = KeyCode.End;
						break;
					case 73:
						KeyRet = KeyCode.Pag_up;
						break;
					case 81:
						KeyRet = KeyCode.Pag_Down;
						break;
					case 82:
						KeyRet = KeyCode.Insert;
						break;
					case 83:
						KeyRet = KeyCode.Del;
						break;
					case 91:
						KeyRet = KeyCode.Win_Left;
						break;
					case 92:
						KeyRet = KeyCode.Win_Right;
						break;
					case 93:
						KeyRet = KeyCode.Menu;
						break;
					#endregion
				
					#region Math Extended					
					case 53:
						KeyRet = KeyCode.Divide;
						break;
					#endregion
				}
			}
			//else //No es extendido
			//{
				
			//}
			return KeyRet;
		}
		
		#endregion
		
		#region X11
		public static KeyCode X11key(uint keycode)
		{
			KeyCode KeyRet = KeyCode.Unknown;
			//Usar comando xev para saber keycode.
			switch(keycode)
			{
				#region System Keys:
				case 9:
					KeyRet = KeyCode.ESC;
					break;
				case 22:
					KeyRet = KeyCode.BackSpace;
					break;
				case 23:
					KeyRet = KeyCode.Tab;
					break;
				case 36:
					KeyRet = KeyCode.Return;
					break;
				case 104:
					KeyRet = KeyCode.Intro;
					break;
				case 66:
					KeyRet = KeyCode.CapsLock;
					break;
				case 50:
					KeyRet = KeyCode.Shift_Left;
					break;
				case 62:
					KeyRet = KeyCode.Shift_Right;
					break;
				case 37:
					KeyRet = KeyCode.Control_Left;
					break;
				case 105:
					KeyRet = KeyCode.Control_Right;
					break;
				case 64:
					KeyRet = KeyCode.Alt;
					break;
				case 108:
					KeyRet = KeyCode.AltGr;
					break;
				case 65:
					KeyRet = KeyCode.Space;
					break;
				case 107:
					KeyRet = KeyCode.PrintScreen;
					break;
				case 78:
					KeyRet = KeyCode.Scroll;
					break;
				case 127:
					KeyRet = KeyCode.Pause;
					break;
				case 133:
					KeyRet = KeyCode.Win_Left;
					break;
				case 134:
					KeyRet = KeyCode.Win_Right;
					break;
				case 135:
					KeyRet = KeyCode.Menu;
					break;
				case 110:
					KeyRet = KeyCode.Home;
					break;
				case 115:
					KeyRet = KeyCode.End;
					break;
				case 118:
					KeyRet = KeyCode.Insert;
					break;
				case 119:
					KeyRet = KeyCode.Del;
					break;
				case 112:
					KeyRet = KeyCode.Pag_up;
					break;
				case 117:
					KeyRet = KeyCode.Pag_Down;
					break;
				case 77:
					KeyRet = KeyCode.NumLock;
					break;
					#endregion
					
				#region NÚMEROS:
				case 10:
					KeyRet = KeyCode.number1;
					break;
				case 11:
					KeyRet = KeyCode.number2;
					break;
				case 12:
					KeyRet = KeyCode.number3;
					break;
				case 13:
					KeyRet = KeyCode.number4;
					break;
				case 14:
					KeyRet = KeyCode.number5;
					break;
				case 15:
					KeyRet = KeyCode.number6;
					break;
				case 16:
					KeyRet = KeyCode.number7;
					break;
				case 17:
					KeyRet = KeyCode.number8;
					break;
				case 18:
					KeyRet = KeyCode.number9;
					break;
				case 19:
					KeyRet = KeyCode.number0;
					break;

				case 87:
					KeyRet = KeyCode.numberPad1;
					break;
				case 88:
					KeyRet = KeyCode.numberPad2;
					break;
				case 89:
					KeyRet = KeyCode.numberPad3;
					break;
				case 83:
					KeyRet = KeyCode.numberPad4;
					break;
				case 84:
					KeyRet = KeyCode.numberPad5;
					break;
				case 85:
					KeyRet = KeyCode.numberPad6;
					break;
				case 79:
					KeyRet = KeyCode.numberPad7;
					break;
				case 80:
					KeyRet = KeyCode.numberPad8;
					break;
				case 81:
					KeyRet = KeyCode.numberPad9;
					break;
				case 90:
					KeyRet = KeyCode.numberPad0;
					break;
				#endregion
					
				#region LETRAS:
				case 38:
					KeyRet = KeyCode.a;
					break;
				case 56:
					KeyRet = KeyCode.b;
					break;
				case 54:
					KeyRet = KeyCode.c;
					break;
				case 40:
					KeyRet = KeyCode.d;
					break;
				case 26:
					KeyRet = KeyCode.e;
					break;
				case 41:
					KeyRet = KeyCode.f;
					break;
				case 42:
					KeyRet = KeyCode.g;
					break;
				case 43:
					KeyRet = KeyCode.h;
					break;
				case 31:
					KeyRet = KeyCode.i;
					break;
				case 44:
					KeyRet = KeyCode.j;
					break;
				case 45:
					KeyRet = KeyCode.k;
					break;
				case 46:
					KeyRet = KeyCode.l;
					break;
				case 58:
					KeyRet = KeyCode.m;
					break;
				case 57:
					KeyRet = KeyCode.n;
					break;
				case 32:
					KeyRet = KeyCode.o;
					break;
				case 33:
					KeyRet = KeyCode.p;
					break;
				case 24:
					KeyRet = KeyCode.q;
					break;
				case 27:
					KeyRet = KeyCode.r;
					break;
				case 39:
					KeyRet = KeyCode.s;
					break;
				case 28:
					KeyRet = KeyCode.t;
					break;
				case 30:
					KeyRet = KeyCode.u;
					break;
				case 55:
					KeyRet = KeyCode.v;
					break;
				case 25:
					KeyRet = KeyCode.w;
					break;
				case 53:
					KeyRet = KeyCode.x;
					break;
				case 29:
					KeyRet = KeyCode.y;
					break;
				case 52:
					KeyRet = KeyCode.z;
					break;
				#endregion
				
				#region Math:
				case 82:
					KeyRet = KeyCode.Minus;
					break;
				case 86:
					KeyRet = KeyCode.Plus;
					break;
				case 63:
					KeyRet = KeyCode.Multiply;
					break;
				case 106:
					KeyRet = KeyCode.Divide;
					break;
				case 34:
					KeyRet = KeyCode.Bracket_Left;
					break;
				case 35:
					KeyRet = KeyCode.Braket_Right;
					break;
				case 94:
					KeyRet = KeyCode.Less;
					break;
				#endregion

				#region Arrows:
				case 111:
					KeyRet = KeyCode.UP;
					break;
				case 116:
					KeyRet = KeyCode.DOWN;
					break;
				case 113:
					KeyRet = KeyCode.LEFT;
					break;
				case 114:
					KeyRet = KeyCode.RIGHT;
					break;
				#endregion

				#region Function Keys:
				case 67:
				KeyRet = KeyCode.F1;
					break;
				case 68:
				KeyRet = KeyCode.F2;
					break;
				case 69:
				KeyRet = KeyCode.F3;
					break;
				case 70:
				KeyRet = KeyCode.F4;
					break;
				case 71:
				KeyRet = KeyCode.F5;
					break;
				case 72:
				KeyRet = KeyCode.F6;
					break;
				case 73:
				KeyRet = KeyCode.F7;
					break;
				case 74:
				KeyRet = KeyCode.F8;
					break;
				case 75:
				KeyRet = KeyCode.F9;
					break;
				case 76:
				KeyRet = KeyCode.F10;
					break;
				case 95:
				KeyRet = KeyCode.F11;
					break;
				case 96:
				KeyRet = KeyCode.F12;
					break;
				#endregion
			
				#region Simbolos: (Pendiente)
				case 47:
					KeyRet = KeyCode.SemiColon;
					break;
				case 48:
					KeyRet = KeyCode.Quote;
					break;
				case 49:
					KeyRet = KeyCode.Grave_Accent;
					break;
				case 61:
					KeyRet = KeyCode.Slash;
					break;
				case 59:
					KeyRet = KeyCode.Comma;
					break;
				case 60:
					KeyRet = KeyCode.Period;
					break;
				case 51: 
					KeyRet = KeyCode.BackSlash;
					break;
				#endregion

				default:
					KeyRet = KeyCode.Unknown;
					break;
			}
			return KeyRet;
		}
		#endregion
    }
}