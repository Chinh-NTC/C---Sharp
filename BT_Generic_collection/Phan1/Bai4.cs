using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai4
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachSo = new List<int> { 10, 25, 7, 99, 18, 2, 4, 15 };
            Console.WriteLine("Danh sách số nguyên: ");
            foreach(int i in danhSachSo)
            {
                Console.Write(i+" ");
            }    

            int soLuongChan = 0;
            foreach (int n in danhSachSo)
            {
                if (n % 2 == 0)
                {
                    soLuongChan++;
                }
            }
            
            Console.WriteLine($"\nSố lượng số chẵn tìm được là: {soLuongChan}");

            Console.ReadKey();
        }
    }
}
