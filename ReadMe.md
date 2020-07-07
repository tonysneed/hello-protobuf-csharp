# Introduction to Protobuf for C#

> **Prerequisites**:
> - Install the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core).
> - Install the [proto3](https://marketplace.visualstudio.com/items?itemName=zxh404.vscode-proto3) extension for Visual Studio Code.

> **Resources**:
> - [Protobuf C# Tutorial](https://developers.google.com/protocol-buffers/docs/csharptutorial)
> - [Protobuf Language Guide](https://developers.google.com/protocol-buffers/docs/proto3)
> - [Google API Design Guide](https://cloud.google.com/apis/design/)
> - [AddressBook.proto example](https://github.com/protocolbuffers/protobuf/blob/master/examples/addressbook.proto)
> - [AddressBook generated classes](https://github.com/protocolbuffers/protobuf/tree/master/csharp/src/AddressBook)

1. Install the **protoc** Protobuf compiler.
   - The easiest way to do this is to use the `Grpc.Tools` package which contains the compiler.
   - Make sure that the current folder has a **.csproj** file.
   - Add `Grpc.Tools` package:
   ```
   dotnet add package Grpc.Tools --version 2.30.0
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
     - Mac: Edit bash_profile with `nano ~/.bash_profile`, add following
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

2. Create a new proto file.
   - Use `dotnet new proto` command to create a new .proto file.
   ```bash
   dotnet new proto -o proto/Weather -na HelloProtobufCSharp.v1.Models --force
   ```
   - This will create a **Weather.proto** file in a proto/Weather folder.
     - The namespace will be set to `HelloProtobufCSharp.v1.Models`
   - Use the [proto3 code snippets](https://marketplace.visualstudio.com/items?itemName=zxh404.vscode-proto3) to flesh out the proto file.
     - **pkg**: `package weather;`
     - **imp**: `import "google/protobuf/timestamp.proto";`
     - **msg**: `message WeatherData { }`
     - **fst**: `string summary = 1;`
     - **fi32**: `int32 temperatureF = 2;`
     - **[none]**: `google.protobuf.Timestamp dateTimeStamp = 3;`

3. Compile proto file to generate C# class.
   - Add **Google.Protobuf** package.
  ```bash
  dotnet add package Google.Protobuf
  ```
  - Add **Models** folder to HelloProtobufCSharp project.
  - Run `protoc` command to generate classes from the .proto file.
  ```bash
  # macOS
  protoc --csharp_out Models \
      --proto_path proto \
      --proto_path ~/.nuget/packages/grpc.tools/2.30.0/build/native/include \
      proto/Weather/Weather.proto
  # Windows
  protoc --csharp_out Models --proto_path proto --proto_path %USERPROFILE%\.nuget\packages\grpc.tools\2.30.0\build\native\include proto\Weather\Weather.proto
  ```
   - This will generate a `Weather` class in the **Models** folder.

4. Add code to `Program.Main`.
   - Create new `WeatherData` instance.
   - Write to stream and buffer.
   - Copy buffer to new `WeatherData` instance.
   - Perform deep comparison of original and copy based on equality.
