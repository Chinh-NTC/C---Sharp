using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai9
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachGoc = new List<int> { 1, 2, 2, 3, 4, 4, 4, 5, 1 };

            List<int> danhSachMoi = new List<int>();
            foreach (int so in danhSachGoc)
            {
                if (!danhSachMoi.Contains(so))
                    danhSachMoi.Add(so);
            }

            Console.WriteLine("Danh sách gốc: " + string.Join(", ", danhSachGoc));
            Console.WriteLine("Danh sách mới (không trùng lặp): " + string.Join(", ", danhSachMoi));

            Console.ReadKey();
        }
    }
}
