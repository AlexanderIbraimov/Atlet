using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace AtletKg.Model
{
    public class Clothes : IComparable
    {
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
    }
}
