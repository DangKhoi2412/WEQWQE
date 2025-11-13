using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class ClimpBicycle : ABicycle
    {
        public int ClimpRate { get; set; } // số bước leo dốc

        public ClimpBicycle(int id, string color, double price, int climpRate)
            : base(id, color, price)
        {
            ClimpRate = climpRate;
        }

        public override void Print()
        {
            Console.WriteLine($"ClimpBicycle - ID: {Id}, Màu: {Color}, Giá: {Price}, Leo dốc: {ClimpRate} bước");
        }
    }
}
