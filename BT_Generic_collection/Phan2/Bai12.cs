using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai12
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    internal class Bai12
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> dsSinhVien = new List<Student>
            {
                new Student(1, "An"),
                new Student(2, "Bình"),
                new Student(3, "Cường"),
                new Student(4, "Diệu")
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student sv in dsSinhVien)
            {
                Console.WriteLine($"Mã SV: {sv.Id} | Họ tên: {sv.Name}");
            }

            Console.Write("Nhập tên sinh viên cần tìm: ");
            string tuKhoa = Console.ReadLine();

            Console.WriteLine("\n----- KẾT QUẢ TÌM KIẾM -----");
            bool timThay = false;
            foreach (Student sv in dsSinhVien)
            {
                if (sv.Name.ToLower().Contains(tuKhoa.ToLower()))
                {
                    Console.WriteLine($"Mã SV: {sv.Id} | Họ tên: {sv.Name}");
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy sinh viên nào có tên phù hợp.");

            Console.ReadKey();
        }
    }
}
