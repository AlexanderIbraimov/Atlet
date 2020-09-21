using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AtletKg
{
    public static class Log
    {
        static string fileName = DateTime.Now.ToString("dd MMMM yyyy")+".txt";
        static string nameFolder = "Log";
        public static void AddError(Exception e)
        {
            FileHelper.Create(fileName, nameFolder);
            FileHelper.WriteLine(nameFolder, fileName, "------------------------------------------------------------------------------------------");
            FileHelper.WriteLine(nameFolder, fileName, "DATETIME  :\t" + DateTime.Now.ToString());
            FileHelper.WriteLine(nameFolder, fileName, "MESSAGE   :\t" + e.Message);
            FileHelper.WriteLine(nameFolder, fileName, "STACKTRACE:\n" + e.StackTrace);
        }
    }
}
