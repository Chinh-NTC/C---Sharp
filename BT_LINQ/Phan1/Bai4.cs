using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai4
{
    internal class Bai4
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

            var sapXepGiamDan = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine("\nBài 4:");
            Console.WriteLine("Danh sách giảm dần: ");
            foreach (var i in sapXepGiamDan)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
