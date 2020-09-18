using System;
using System.Collections.Generic;
using System.Text;

namespace AtletKg.Model
{
    public static class FileCSV
    {
        static string fileName = "Отчёт " + DateTime.Now.ToString("dd MMMM yyyy");

        public static void Create()
        {
            FileHelper.Create(fileName, "Data", ".csv");
            FileHelper.Write(fileName, "Название;");
            FileHelper.Write(fileName, "Размер;");
            FileHelper.Write(fileName, "Цена закупки;");
            FileHelper.Write(fileName, "Цена продажи;");
        }

        public static void AddClothes(Clothes clothes)
        {
            FileHelper.Write(fileName, "\n"+clothes.Name + ";");
            FileHelper.Write(fileName, clothes.Size + ";");
            FileHelper.Write(fileName, clothes.Price + ";");
            FileHelper.Write(fileName, clothes.SellingPrice + ";");
        }
    }
}
