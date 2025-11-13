using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class SpeedBicycle : ABicycle
    {
        public int SpeedRate { get; set; }

        public SpeedBicycle(int id, string color, double price, int speedRate)
            : base(id, color, price)
        {
            SpeedRate = speedRate;
        }

        public override void Print()
        {
            Console.WriteLine($"SpeedBicycle - ID: {Id}, Màu: {Color}, Giá: {Price}, Tăng tốc: {SpeedRate} bước");
        }
    }
}
