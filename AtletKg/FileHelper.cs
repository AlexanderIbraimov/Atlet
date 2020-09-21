using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace AtletKg
{
    public static class FileHelper
    {
        static string path = Environment.CurrentDirectory;
        static Dictionary<string, string> GetnameFilePaths(string nameFolder)
        {
            var filesPaths= Directory.GetFiles(path + "\\" + nameFolder);
            var result = new Dictionary<string, string>();

            foreach (var filepath in filesPaths)
            {
                var path = filepath.Split("\\");
                var fileName = path[path.Length-1];
                result.Add(fileName, filepath);
            }
            return result;
        }
        public static void Create(string fileName, string nameFolder, string message = "")
        {
            var fullPath = path + "\\" + nameFolder;
            if (!File.Exists(fullPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                if (!dirInfo.Exists)
                    dirInfo.Create();
            }
            Write(nameFolder, fileName, message);
        }

        public static void Write(string nameFolder, string fileName, string message)
        {
            var pathFile = path + "\\" + nameFolder + "\\" + fileName;
            using (StreamWriter streamWriter = new StreamWriter(pathFile, true, Encoding.Default))
            {
                streamWriter.Write(message);
            }
        }

        public static void WriteLine(string nameFolder, string fileName, string message) => Write(nameFolder, fileName, message + "\n");

        public static List<string> ReadLine(string nameFolder, string fileName)
        {
            List<string> lines = new List<string>();
            var nameFilePaths = GetnameFilePaths(nameFolder);
            if (nameFilePaths.ContainsKey(fileName))
            {
                var pathFile = nameFilePaths[fileName];
                using (StreamReader sr = new StreamReader(pathFile, Encoding.Default))
                {
                    while (true) 
                    {
                        var line = sr.ReadLine();
                        if (line != null)
                            lines.Add(line);
                        else break;
                    }
                }
            }
            return lines;
        }
    }
}
