using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtletKg.Model
{
    public static class FileCSV
    {
        static string fileName = DateTime.Now.ToString("dd MMMM yyyy") + ".csv";
        static string nameFolder = "Data\\Report";
        public static void Create(string nameFile, string mainString)
        {
            fileName = nameFile + fileName;
            FileHelper.Create(fileName, nameFolder);
            FileHelper.WriteLine(nameFolder, fileName, mainString);
        }

        public static void AddClothes(Clothes clothes)
        {
            FileHelper.WriteLine(nameFolder, fileName, clothes.ToString());
        }

        public static List<Clothes> GetClothes()
        {
            var report = FileHelper.ReadLine(nameFolder, fileName);
            var result = new List<Clothes>();
            foreach (var line in report.Skip(1))
            {
                result.Add(Clothes.Parse(line)) ;
            }
            return result;
        }
    }
}
