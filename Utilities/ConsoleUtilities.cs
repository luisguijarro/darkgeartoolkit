using System;
using System.Diagnostics;

namespace dgtk;

public static class ConsoleUtils
{
    public static string Centrar(string texto, int ancho)
    {
        if (texto.Length >= ancho)
            return texto;

        int espaciosIzquierda = (ancho - texto.Length) / 2;
        int espaciosDerecha = ancho - texto.Length - espaciosIzquierda;

        return new string(' ', espaciosIzquierda) + texto + new string(' ', espaciosDerecha);
    }

    public static void WriteLineColored(string linea)
    {
        WriteLineColored(linea, ConsoleColor.Yellow, ConsoleColor.White);
    }

    public static void WriteLineColored(string linea, ConsoleColor LinesColor, ConsoleColor CharsColor)
    {
        foreach (char c in linea)
        {
            // Dibujos de cuadro: usar amarillo
            if ("┌┬┐├┼┤└┴┘│─╔═╗╚╝╠╣║╦╩╬╒╓╕╖╘╛╙╡╤╥╧╨╪╫○◉□▣".Contains(c))
                Console.ForegroundColor = LinesColor;
            else
                Console.ForegroundColor = CharsColor;

            Console.Write(c);
        }
        Console.WriteLine();
        Console.ResetColor();
    }

    [Conditional("DEBUG")]
    public static void LogWarning(string message)
    {
        WriteLineColored(message, ConsoleColor.Yellow, ConsoleColor.Yellow);
    }

    [Conditional("DEBUG")]
    public static void LogError(string message)
    {
        WriteLineColored(message, ConsoleColor.Red, ConsoleColor.Red);
    }
}
