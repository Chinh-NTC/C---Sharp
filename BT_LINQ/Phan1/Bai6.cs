using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_Bai6
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Danh sách ban đầu: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            var dem_numbers_chan = numbers.Where(n => n % 2 == 0).Count();
            Console.WriteLine("\nBài 6: ");
            Console.WriteLine("Trong danh sách có {0} số chẵn.", dem_numbers_chan);

            Console.ReadKey();
        }
    }
}
