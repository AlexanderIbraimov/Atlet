using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace AtletKg.Model
{
    public class Clothes : IComparable
    {
        public Clothes() { }
        public Clothes(string name, string size, int price, int sellingPrice) 
        {
            Name = name;
            Size = size;
            Price = price;
            SellingPrice = sellingPrice;
        }

        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int SellingPrice { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Clothes)
            {
                var clothes = obj as Clothes;
                if (clothes.Name == Name && clothes.Size == Size)
                    return 0;
                else
                    return -1;
            }
            else return -1;
        }

        public override string ToString()
        {
            return Name + ";" + Size + ";" + Price + ";" + SellingPrice;
        }

        public static Clothes Parse(string clothesStr) 
        {
            var lines = clothesStr.Split(";");
            var name = lines[0];
            var size = lines[1];
            var price = int.Parse(lines[2]);
            var sellingPrice = int.Parse(lines[3]);
            return new Clothes(name, size, price, sellingPrice);
        }
    }
}
