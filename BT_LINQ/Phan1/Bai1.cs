using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Danh sách ban đầu: ");
            foreach(int i in numbers)
            {
                Console.Write(i + " "); 
            }

            Console.WriteLine("\nDanh sách các số chẵn: ");    
            var numbers_chan = numbers.Where(n => n %2  == 0).ToList();

            foreach(var  n in numbers_chan)
            {
                Console.Write(n + " "); 
            }    

            Console.ReadKey();
        }
    }
}
