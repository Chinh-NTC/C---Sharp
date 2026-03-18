using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai17
{
    internal class Bai17
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSach = new List<int> { 1, 3, 2, 3, 4, 1, 3, 5, 2 };
            Console.WriteLine("Danh sách: " + string.Join(", ", danhSach));
            Dictionary<int, int> thongKe = new Dictionary<int, int>();

            foreach (int so in danhSach)
            {
                if (thongKe.ContainsKey(so))
                    thongKe[so]++;
                else
                    thongKe.Add(so, 1);
            }

            int soXuatHienNhieuNhat = danhSach[0];
            int soLanMax = 0;

            foreach (var entry in thongKe)
            {
                if (entry.Value > soLanMax)
                {
                    soLanMax = entry.Value;
                    soXuatHienNhieuNhat = entry.Key;
                }
            }

            Console.WriteLine($"\n==> Số xuất hiện nhiều nhất là: {soXuatHienNhieuNhat}");
            Console.WriteLine($"==> Số lần xuất hiện: {soLanMax} lần");

            Console.ReadKey();
        }
    }
}
