using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai19
{
    internal class Bai19
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sách ban đầu: ");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }

            // Nhóm các số trùng nhau thành 1 nhóm 
            // Sắp xếp các nhóm giảm dần theo số lượng 
            // Lấy nhóm đầu tiên
            var numbers_laplaitop1 = numbers.GroupBy(n => n).OrderByDescending(d => d.Count()).FirstOrDefault();

            Console.WriteLine("\nBài 19: ");
            Console.WriteLine("Tìm số xuất hiện nhiều nhất: ");
            if(numbers_laplaitop1 != null)
                Console.WriteLine("Số {0} xuất hiện nhiều lần nhất với {1} lần xuất hiện.", numbers_laplaitop1.Key, numbers_laplaitop1.Count());
        
            Console.ReadKey();
        }
    }
}
