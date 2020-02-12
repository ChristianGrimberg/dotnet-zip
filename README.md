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
    git clone https://github.com/ChristianGrimberg/dotnet-zip.git
    ```
* To test this app, run this command:
    ```bash
    dotnet run <source> <target>.zip
    ```
### Optional steps
* Add Nlog Package to your local copy of this repo
    ```bash
    dotnet add package NLog
    ```