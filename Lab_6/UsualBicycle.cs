using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class UsualBicycle : ABicycle
    {
        public string Utility { get; set; }

        public UsualBicycle(int id, string color, double price, string utility)
            : base(id, color, price)
        {
            Utility = utility;
        }

        public override void Print()
        {
            Console.WriteLine($"UsualBicycle - ID: {Id}, Màu: {Color}, Giá: {Price}, Phụ kiện: {Utility}");
        }
    }
}
