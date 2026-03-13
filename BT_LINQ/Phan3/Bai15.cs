using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_Bai15
{
    internal class Bai15
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

            var dsKhongTrung = numbers.Distinct().ToList();
            Console.WriteLine("\nBài 15: ");
            Console.WriteLine("Danh sách sau khi loại bỏ số trùng:");
            foreach (var n in dsKhongTrung)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }
    }
}
