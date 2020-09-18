using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Text;

namespace AtletKg
{
    public static class FileHelper
    {
        static string path = Environment.CurrentDirectory;
        static Dictionary<string, string> nameFilePaths = new Dictionary<string, string>();

        public static void Create(string fileName, string nameFolder, string format, string message = "")
        {
            var fullPath = path + "\\" +nameFolder;
            if (!File.Exists(fullPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                if (!dirInfo.Exists)
                    dirInfo.Create();
            }
            var pathFile = fullPath + "\\" + fileName + format;
            nameFilePaths.Add(fileName, pathFile);
            Write(fileName, message);
        }

        public static void Write(string fileName, string message)
        {
            if (nameFilePaths.ContainsKey(fileName))
            {
                var pathFile = nameFilePaths[fileName];
                using (StreamWriter streamWriter = new StreamWriter(pathFile, true, Encoding.Default))
                {
                    streamWriter.Write(message);
                }
            }
        }

        public static void WriteLine(string fileName, string message) => Write(fileName,  message + "\n");
    }
}
