using System;

namespace dgtk
{
	public enum EnterLeave
	{
		Enter, Leave
	}

	public enum MouseButtons : uint
	{
		Left = 1, Center = 2, Right = 3
	}

	public enum PushRelease : byte
	{
		Push = 1,
		Release = 0
	}

	public enum KeyCode
	{
		Unknown,
		//OTHERS
		PrintScreen, BloqDespl, Pause,
		//FUNKEYS
		F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
		//LETRAS:
		a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z,
		//NÚMEROS:
		number0, number1, number2, number3, number4,
		number5, number6, number7, number8, number9,
		//ARROW:
		UP, DOWN, LEFT, RIGHT,
		//BLOQUE NÚMERICO:
		NumLock,
		numberPad0, numberPad1, numberPad2, numberPad3, numberPad4,
		numberPad5, numberPad6, numberPad7, numberPad8, numberPad9,
		//MATH:
		Plus, Minus, Multiply, Divide, Less,
		//SYSTEM:
		Tab, Shift_Left, Shift_Right, Control_Left, Control_Right, Menu,
		Alt, AltGr, CapsLock, Return, Intro, BackSpace, Space, Del,
		Pag_up, Pag_Down, Home, End, Insert, ESC, Win_Left, Win_Right, Scroll,
		Bracket_Left, Braket_Right, BackSlash, Quote,
		SemiColon, Comma, Period, Slash, Grave_Accent

	}
}