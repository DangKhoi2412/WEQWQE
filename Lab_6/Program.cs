using System.Text;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Store store = new Store();

            Console.WriteLine("=== Danh sách xe đạp trong cửa hàng ===");
            store.PrintAll();

            // Tìm kiếm xe trong khoảng giá
            store.SearchByPrice(800, 1500);

            // Sắp xếp tăng dần theo giá
            Console.WriteLine("\n=== Danh sách xe (sắp xếp tăng dần theo giá) ===");
            store.SortByPrice(true);
            store.PrintAll();

            // Thử giảm giá một xe
            Console.WriteLine("\n=== Giảm giá xe có ID = 3 ===");
            foreach (var bike in new List<ABicycle> { })
                bike.MakeDeal(3);
        }
    }
}
