using System;
using NLog;
using zipper;

namespace dotnet_zip_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = null;
            string target = null;

            if(args == null || args.Length != 2)
            {
                Console.WriteLine("Use: dotnet-zip-app <source> <target>.zip");
            }
            else
            {
                source = args[0];
                target = args[1];

                ConfigureLog();

                try
                {
                    ZipperLogic.Zip(source, target);
                }
                catch (System.Exception ex)
                {
                    LogManager.GetCurrentClassLogger().Error(ex.Message);
                }

                Console.WriteLine("The program has finished.");
            }
        }

        private static void ConfigureLog()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "log.txt"};

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;
        }
    }
}
