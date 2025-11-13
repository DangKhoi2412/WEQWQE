using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public abstract class ABicycle
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public ABicycle(int id, string color, double price)
        {
            Id = id;
            Color = color;
            Price = price;
        }

        public abstract void Print();

        public void MakeDeal(int id)
        {
            if (Id == id)
            {
                Price *= 0.9;
                Console.WriteLine($"Xe {Id} đã được giảm giá 10% còn {Price}");
            }
        }
    }
}
