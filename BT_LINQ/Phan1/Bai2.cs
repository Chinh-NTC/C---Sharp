using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
namespace BT_LINQ_Bai2
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 , 8};
            Console.WriteLine("Danh sách ban đầu: ");
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }

            var kt = numbers.Where(n => n > 5).ToList();
            Console.WriteLine("\nBài 2:");
            Console.WriteLine("Danh sách các số lớn hơn 5: ");
            foreach(var i in kt)
            {
                Console.Write(i + " ");
            }    

            Console.ReadKey();
        }
    }
}
