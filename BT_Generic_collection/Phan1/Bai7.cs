using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai7
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachSo = new List<int>();
            Console.Write("Bạn muốn nhập bao nhiêu số:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                danhSachSo.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nDanh sách vừa nhập: " + string.Join(", ", danhSachSo));

            danhSachSo.Sort();

            Console.WriteLine("Danh sách sau khi sắp xếp tăng dần: " + string.Join(", ", danhSachSo));

            Console.ReadKey();
        }
    }
}
