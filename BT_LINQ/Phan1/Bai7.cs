using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
namespace BT_LINQ_Bai7
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine("Danh sách ban đầu: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            bool kt_numbers = numbers.Any(n => n > 10);
            Console.WriteLine("\nBài 7: ");
            Console.WriteLine("Danh sách có số lớn hơn 10: "+kt_numbers);

            Console.ReadKey();
        }
    }
}
