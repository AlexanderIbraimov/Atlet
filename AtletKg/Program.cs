using AtletKg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtletKg
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FileCSV.Create("Продано ", "Название;Размер;Цена закупки;Цена продажи;");
            var c1 = new Clothes();
            c1.Name = "Nike";
            c1.Price = 12312;
            c1.SellingPrice = 321312;
            c1.Size = "XXL";
            FileCSV.AddClothes(c1);
            var c2 = new Clothes();
            c2.Name = "adi";
            c2.Price = 12321;
            c2.SellingPrice = 3123;
            c2.Size = "XL";
            FileCSV.AddClothes(c2);
            var c3 = new Clothes();
            c3.Name = "puma";
            c3.Price = 321213;
            c3.SellingPrice = 12321;
            c3.Size = "L";
            FileCSV.AddClothes(c3);
            var c4 = new Clothes();
            c4.Name = "sasha";
            c4.Price = 123;
            c4.SellingPrice = 123;
            c4.Size = "XLX";
            FileCSV.AddClothes(c4);
            var c5 = new Clothes();
            c5.Name = "nastya";
            c5.Price = 321;
            c5.SellingPrice = 123;
            c5.Size = "XXX";
            FileCSV.AddClothes(c5);

            var sd = FileCSV.GetClothes();

            Application.Run(new MainWindow());
        }
    }
}
