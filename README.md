[![.NET Core Build, Test, Publish and Run application](https://github.com/ChristianGrimberg/dotnet-zip-app/actions/workflows/dotnet-core-actions.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/dotnet-zip-app/actions/workflows/dotnet-core-actions.yml)
# My first .NET Core Console Application
This app is development with .NET Core 3.1 Framework.
## How it works
* You need to download the .NET Core SDK at [http://aka.ms/dotnet-download](http://aka.ms/dotnet-download)
* When it finished, see the .net core installed in your system:
    ```bash
    dotnet --info
    ```
* After that clone this repo with Git:
    ```bash
    git clone https://github.com/ChristianGrimberg/dotnet-zip-app.git
    ```
* Add Nlog Package with NuGet to your local copy of this repo
    ```bash
    cd dotnet-zip-app/
    dotnet add package NLog
    ```
* To build to test if works on your system:
    ```bash
    dotnet build
    ```
* To run this app type this command:
    ```bash
    dotnet run <source> <target>.zip
    ```
### Optional steps
* To remove the Nlog package:
    ```bash
    dotnet remove package NLog
    ```
* To publish the app to Linux envirorment:
    ```bash
    dotnet publish --self-contained -r linux-x64 -c Release
    ```
* To publish the app to MacOS Big Sur envirorment:
    ```bash
    dotnet publish --self-contained -r osx.11.0-x64 -c Release
    ```
* To publish the app to Windows 10 envirorment:
    ```bash
    dotnet publish --self-contained -r win10-x64 -c Release
    ```
### Steps to develop the Zipper App solution
```bash
dotnet new classlib -n zipper
dotnet new console -n dotnet-zip-app
dotnet new sln
dotnet sln add zipper
dotnet sln add app
dotnet add app reference zipper
```
### Pack Class Library like NuGet Package
```bash
dotnet pack -c Release
```
Then, you need to go to Release folder and find the nupkg file extension.
