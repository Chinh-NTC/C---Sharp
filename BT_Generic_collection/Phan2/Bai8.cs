using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSach = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", danhSach));
            danhSach.Reverse();
            Console.WriteLine("Danh sách sau khi đảo ngược: " + string.Join(", ", danhSach));

            Console.ReadKey();
        }
    }
}
