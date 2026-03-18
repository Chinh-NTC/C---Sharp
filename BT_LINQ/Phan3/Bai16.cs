using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai16
{
    internal class Bai16
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sách ban đầu: ");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }

            int numbers_sum = numbers.Sum();
            Console.WriteLine("\nBài 16: ");
            Console.WriteLine("Tổng các số trong danh sách là: " + numbers_sum);

            Console.ReadKey();
        }
    }
}
