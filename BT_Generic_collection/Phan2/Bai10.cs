using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai10
{
    internal class Bai10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachSo = new List<int> { 45, 12, 89, 5, 33, 21 };

            Console.WriteLine("Danh sách hiện tại: ");
            foreach(int so in danhSachSo)
            {
                Console.Write(so+" ");
            }    
            int minGiaTri = danhSachSo[0];
            foreach (int so in danhSachSo)
            {
                if (so < minGiaTri)
                    minGiaTri = so;
            }

            Console.WriteLine("\nSố nhỏ nhất trong danh sách: "+minGiaTri);

            Console.ReadKey();
        }
    }
}
