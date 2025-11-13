using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Store
    {
        private List<ABicycle> bicycles = new List<ABicycle>();
        private Random rnd = new Random();

        public Store()
        {
            string[] colors = { "Đỏ", "Xanh", "Đen", "Trắng", "Vàng" };

            for (int i = 1; i <= 10; i++)
            {
                int type = rnd.Next(3); 
                string color = colors[rnd.Next(colors.Length)];
                double price = rnd.Next(500, 2000);

                switch (type)
                {
                    case 0:
                        bicycles.Add(new UsualBicycle(i, color, price, rnd.Next(2) == 0 ? "Yes" : "No"));
                        break;
                    case 1:
                        bicycles.Add(new SpeedBicycle(i, color, price, rnd.Next(1, 10)));
                        break;
                    case 2:
                        bicycles.Add(new ClimpBicycle(i, color, price, rnd.Next(1, 10)));
                        break;
                }
            }
        }

        public void PrintAll()
        {
            foreach (var bike in bicycles)
                bike.Print();
        }

        public void SearchByPrice(double from, double to)
        {
            Console.WriteLine($"\nXe trong khoảng giá {from} - {to}:");
            foreach (var bike in bicycles.Where(b => b.Price >= from && b.Price <= to))
                bike.Print();
        }

        public void SortByPrice(bool ascending = true)
        {
            if (ascending)
                bicycles = bicycles.OrderBy(b => b.Price).ToList();
            else
                bicycles = bicycles.OrderByDescending(b => b.Price).ToList();
        }
        //DWEWEQE
    }
}
