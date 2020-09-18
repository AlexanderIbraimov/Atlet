using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AtletKg
{
    public static class Log
    {
        static string fileName = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();
        static string path = Environment.CurrentDirectory;
        public static void AddError(Exception e)
        {
            var pathFile = path + $"\\Log\\{fileName}.txt";
            if (!File.Exists(pathFile))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();
            }

            using (StreamWriter streamWriter = new StreamWriter(pathFile, true, Encoding.Default))
            {
                streamWriter.WriteLine("------------------------------------------------------------------------------------------");
                streamWriter.WriteLine("DATETIME  :\t" + DateTime.Now.ToString());
                streamWriter.WriteLine("MESSAGE   :\t" + e.Message);
                streamWriter.WriteLine("STACKTRACE:\n" + e.StackTrace);
            }
        }
    }
}
