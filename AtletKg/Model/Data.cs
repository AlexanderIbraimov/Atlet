using System;
using System.Collections.Generic;
using System.Text;

namespace AtletKg.Model
{
    public class Data
    {
        private List<Clothes> clothes { get; }
        private Dictionary<string, int> NameNumberCount { get; }
        private Dictionary<Tuple<string, string>, int> NameSizeCount { get; }
        public Data()
        {
            clothes = new List<Clothes>();
            NameNumberCount = new Dictionary<string, int>();
        }

        public void Add(Clothes clothes, int number = 1)
        {
            for (int i = 0; i < number; i++)
                this.clothes.Add(clothes);
            if (NameNumberCount.ContainsKey(clothes.Name))
                NameNumberCount[clothes.Name] += number;
            else
                NameNumberCount.Add(clothes.Name, number);

            var tuple = Tuple.Create(clothes.Name, clothes.Size);
            if (NameSizeCount.ContainsKey(tuple))
                NameSizeCount[tuple] += number;
            else
                NameSizeCount.Add(tuple, number);
        }

        public void Remove(Clothes clothes, int number = 1)
        {
            var count = this.clothes.Count;
            for (int i = 0; i < count; i++)
            {
                if (this.clothes[i].CompareTo(clothes) == 0)
                {
                    this.clothes.RemoveAt(i);
                    count--;
                }
            }
        }

        //public List<Clothes> GetClothes(string name) 
        //{
            
        //}
    }
}
