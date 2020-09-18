using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AtletKg
{
    public static class Log
    {
        static string fileName = DateTime.Now.ToString("dd MMMM yyyy");

        public static void AddError(Exception e)
        {
            FileHelper.Create(fileName, "Log", ".txt");
            FileHelper.WriteLine(fileName, "------------------------------------------------------------------------------------------");
            FileHelper.WriteLine(fileName, "DATETIME  :\t" + DateTime.Now.ToString());
            FileHelper.WriteLine(fileName, "MESSAGE   :\t" + e.Message);
            FileHelper.WriteLine(fileName, "STACKTRACE:\n" + e.StackTrace);
        }
    }
}
