# Dark Gear Tool Kit
Tool Kit Library developed for **DarkGear Game Engine** with support for OpenGL, OpenAL and Input Devices.

## Compilation
To compile the project use the command **dotnet publish:**
  - Windows: dotnet publish ollvaror_cliente.sln --runtime win-x64 -c release -p:PublishTrimmed=true --self-contained true
  - Linux: dotnet publish ollvaror_cliente.sln --runtime linux-x64 -c release -p:PublishTrimmed=true --self-contained true

Note: Change "release" word by "debug" word for debug output.

## Prerequisites:
For Compilation: **.NET 5**

For use: **OpenAL Soft ( soft_oal.dll, libopenal.so.1 )**

`Note Windows: Do not rename the library soft_oal.dll`

`Note Linux: Do not rename the library libopenal.so.1`

`Note: We include a version of the library in order to facilitate the process of using this software. However, we always recommend using the latest version of it available in its official repository.`

OpenAL Soft is LGPL Software:
[https://github.com/kcat/openal-soft](https://github.com/kcat/openal-soft)
