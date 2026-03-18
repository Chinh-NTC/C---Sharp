using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai3
{
    internal class Bai3
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

            var sapXepTangDan = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("\nBài 3:");
            Console.WriteLine("Danh sách tăng dần: ");
            foreach(var i  in sapXepTangDan)
            {
                Console.Write(i + " ");
            } 

            Console.ReadKey();
                
        }
    }
}
