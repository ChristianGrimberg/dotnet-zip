using System;
using System.IO.Compression;

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

                ZipFile.CreateFromDirectory(source, target);
            }
        }
    }
}
