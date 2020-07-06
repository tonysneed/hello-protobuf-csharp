# Hello Protobuf for C#

> **Prerequisites**: Install the [Nuget CLI](https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools#nugetexe-cli).
> Windows users can install it from [here](https://www.nuget.org/downloads).

1. Install the **protoc** Protobuf compiler.
   - The easiest way to do this is to use the `Grpc.Tools` package which contains the compiler.
   - Make sure that the current folder has a **.csproj** file.
   - Add `Grpc.Tools` package:
   ```
   dotnet add package Grpc.Tools
   ```
   - Note the NuGet package cache location on your machine.
    ```
    dotnet nuget locals global-packages --list
    ```
   - Locate the folder in which the protoc file resides.
     - Note the latest version of grpc.tools.
    ```bash
    # macOS
    /.nuget/packages/grpc.tools/2.30.0/tools/macosx_x64
    # Windows
    %USERPROFILE%\.nuget\packages\grpc.tools\2.30.0\tools\windows_x64
    ```
   - On Mac change to folder and set permissions: `chmod +x protoc`
   - Set your `PATH` environment variable to this location.
     - Mac: Edit bash_profile, add following
   ```bash
   # macOS
   export PATH="$PATH:~/.nuget/packages/grpc.tools/2.30.0/tools/macosx_x64"
   ```
     - Windows: Open command prompt as administrator
   ```bash
   # Windows
   SETX /M PATH "%PATH%;%USERPROFILE%\.nuget\packages\grpc.tools\2.30.0\tools\windows_x64"
   ```
   - Run `protoc` from a terminal to make sure it works.
