using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerClient
{
    public static class Statics
    {
        private static string ProgramDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        public static string AppProgramDataPath => Path.Combine(ProgramDataPath, "WarhammerByLinaq");
        public static string AppName { get; set; } = "Warhammer FRPG by Linaq";
        public static string AppCaption => $"{AppName} (v{string.Join(".", Assembly.GetAssembly(typeof(App)).GetName().Version.ToString().Split('.').Take(3))})";
        public static string LogFilePath => Path.Combine(AppProgramDataPath,"Log.log");

        public static void Initalize()
        {
            if (!Directory.Exists(AppProgramDataPath))
            { 
                Directory.CreateDirectory(AppProgramDataPath);
            }
        }

    }
}
