# Dark Gear Tool Kit (dgtk)

[![NuGet](https://img.shields.io/nuget/v/dgtk.svg)](https://www.nuget.org/packages/dgtk/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/dgtk.svg)](https://www.nuget.org/packages/dgtk/)

**Dark Gear Tool Kit (dgtk)** es una librería en C# desarrollada para el **DarkGear Game Engine**, con soporte para:

- OpenGL y OpenGL|ES  
- OpenAL (audio)  
- Dispositivos de entrada  

Está diseñada para ser **multiplataforma** (Windows y Linux) y funcionar tanto en **x64** como en **ARM64**.

---

## 📦 Instalación desde NuGet

Puedes añadir la librería directamente desde [NuGet](https://www.nuget.org/packages/dgtk/):

```bash
dotnet add package dgtk
```

Esto descargará automáticamente la última versión disponible.

## ⚙️ Compilación manual

Si deseas compilar el proyecto desde el código fuente:

### Windows
```cmd
dotnet publish DarkGearToolKit.sln --runtime win-x64 -c Release -p:PublishTrimmed=true --self-contained true
```

### Linux
```bash
dotnet publish DarkGearToolKit.sln --runtime linux-x64 -c Release -p:PublishTrimmed=true --self-contained true
```

Usa Debug en lugar de Release si necesitas una build de depuración.

# 📋 Requisitos

- Para compilar: .NET 8 SDK
- Para ejecutar:
  - OpenAL Soft (soft_oal.dll en Windows, libopenal.so.1 en Linux)

ℹ️ Nota: Incluimos una copia de OpenAL Soft para mayor comodidad, pero recomendamos usar siempre la última versión disponible en su repositorio oficial

⚠️ Importante:
- En Windows no renombres soft_oal.dll.
- En Linux no renombres libopenal.so.1.

# 🚀 Ejemplo de uso básico

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

# 📄 Licencia

Este proyecto está bajo licencia LGPL.

Incluye OpenAL Soft, que está licenciado bajo LGPL:
👉 https://github.com/kcat/openal-soft