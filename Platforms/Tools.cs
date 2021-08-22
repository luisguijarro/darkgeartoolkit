using  System;
using System.Diagnostics;

namespace dgtk.Platforms
{
    public static class Tools
    {
        public static Platform GetPlatform()
        {
            switch(Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return Platform.Windows;
                case PlatformID.Win32S:
                    return Platform.Windows;
                case PlatformID.Win32Windows:
                    return Platform.Windows;
                case PlatformID.WinCE:
                    return Platform.Windows;
                case PlatformID.MacOSX:
                    return Platform.MacOS;
                case PlatformID.Unix:
                    /*System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo = new ProcessStartInfo("/bin/bash");
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.FileName = "/bin/bash echo $WAYLAND_DISPLAY";
                    p.StartInfo.Arguments = "/bin/bash echo $WAYLAND_DISPLAY";
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();*/
                    System.Environment.GetEnvironmentVariable("$XDG_SESSION_TYPE");
                    string output = "";
                    //output = p.StandardOutput.ReadToEnd();
                    /*p.WaitForExit();
                    p.Close();*/
                    if (output.Length >= 7)
                    {
                        if (output.Substring(0, 7) == "wayland")
                        {
                            return Platform.Linux_Wayland;
                        }
                    }
                    return Platform.Linux_X11;
            }
            throw new Exception("Plataform not Supported");
        }
    }

    public enum Platform
    {
        Windows, MacOS, Linux_X11, Linux_Wayland
    }
}
