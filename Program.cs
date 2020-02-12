using System;
using System.IO.Compression;
using NLog;

namespace dotnet_zip
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = null;
            string target = null;

            if(args == null || args.Length != 2)
            {
                Console.WriteLine("Uso: <origen> <destino>.zip");
                return;
            }

            source = args[0];
            target = args[1];

            ConfigureLog();

            try
            {
                ZipFile.CreateFromDirectory(source, target);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Se efectua el registro del error en archivo de log.");

                LogManager.GetCurrentClassLogger().Error(ex.Message);
            }

            return;
        }

        private static void ConfigureLog()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logFile = new NLog.Targets.FileTarget("logfile") {FileName = "Error.log"};

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logFile);

            NLog.LogManager.Configuration = config;
        }
    }
}
