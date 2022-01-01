# Dark Gear Tool Kit
Tool Kit Library developed for **DarkGear Game Engine** with support for OpenGL, OpenAL and Input Devices.

## Compilation
To compile the project use the command **dotnet publish:**
  - Windows: dotnet publish ollvaror_cliente.sln --runtime win-x64 -c release -p:PublishTrimmed=true --self-contained true
  - Linux: dotnet publish ollvaror_cliente.sln --runtime linux-x64 -c release -p:PublishTrimmed=true --self-contained true

Note: Change "release" word by "debug" word for debug output.

## Prerequisites:
For Compilation: **.NET 5**

For use: **OpenAL Soft ( soft_oal.dll )**