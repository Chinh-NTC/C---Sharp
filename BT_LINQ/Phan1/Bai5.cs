using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
namespace BT_LINQ_Bai5
{
    internal class Bai5
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

            var numbers_BinhPhuong = numbers.Select(n => n*n).ToList();
            Console.WriteLine("\nBài 5:");
            Console.WriteLine("Danh sách sau khi bình phương: ");
            foreach(var  i in numbers_BinhPhuong)
            {
                Console.Write(i + " ");
            }    

            Console.ReadKey();
        }
    }
}
