# Hello Protobuf for C#

1. Ensure that the **protoc** Protobuf compiler is installed. The easiest way to do this is to use the `Grpc.Tools` package which contains the compiler.
   - Make sure that the current folder has a **.csproj** file.
   - Add `Grpc.Tools` package: `dotnet add package Grpc.Tools`
   - Note the NuGet package cache location on your machine.

    ```
    nuget locals global-packages -list
    ```
   - Locate the folder in which the protoc file resides.
    ```bash
    # macOS
    /.nuget/packages/grpc.tools/2.30.0/tools/macosx_x64
    # Windows
    
    ```
