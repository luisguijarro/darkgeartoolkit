# Dark Gear Tool Kit (dgtk)

[![NuGet](https://img.shields.io/nuget/v/dgtk.svg)](https://www.nuget.org/packages/dgtk/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/dgtk.svg)](https://www.nuget.org/packages/dgtk/)

**Dark Gear Tool Kit (dgtk)** is a C# library developed for the **DarkGear Game Engine**, with support for:

- OpenGL and OpenGL|ES  
- OpenAL (audio)  
- Input devices  

It is designed to be **cross-platform** (Windows & Linux) and run on both **x64** and **ARM64** architectures.

---

## 📦 Installation via NuGet

You can add the library directly from [NuGet](https://www.nuget.org/packages/dgtk/):

```bash
dotnet add package dgtk
```

This will automatically pull the latest version.

## ⚙️ Manual Build

If you prefer to build from source:


### Windows
```cmd
dotnet publish DarkGearToolKit.sln --runtime win-x64 -c Release -p:PublishTrimmed=true --self-contained true
```

### Linux
```bash
dotnet publish DarkGearToolKit.sln --runtime linux-x64 -c Release -p:PublishTrimmed=true --self-contained true
```

Use Debug instead of Release for debugging builds.

## 📋 Requirements

- To build: .NET 8 SDK
- To run:
  - OpenAL Soft (soft_oal.dll on Windows, libopenal.so.1 on Linux)

ℹ️ Note: We include a copy of OpenAL Soft for convenience, but we recommend using the latest version from its official repository

⚠️ Important:

- Do not rename soft_oal.dll on Windows.

- Do not rename libopenal.so.1 on Linux.

## 🚀 Basic Usage Example
```csharp
using dgtk;

class Program
{
    static void Main()
    {
        var window = new dgtk_Window(800, 600, "Hello dgtk!");
        window.Run();
    }
}
```

## 📄 License

This project is licensed under LGPL.

It includes OpenAL Soft, which is licensed under LGPL:

👉 https://github.com/kcat/openal-soft