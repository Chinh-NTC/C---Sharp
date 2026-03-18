using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai18
{
    class Student
    {
        public string Name;
        public double Score;

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }
    }

    internal class Bai18
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> dsSinhVien = new List<Student>
            {
                new Student("Nguyễn Văn An", 8.5),
                new Student("Trần Thị Bình", 9.2),
                new Student("Lê Văn Cường", 7.8),
                new Student("Phạm Diệu Hoa", 9.5),
                new Student("Hoàng Văn Nam", 8.9)
            };
            Console.WriteLine("Danh sách sinh viên: ");
            foreach(Student st in dsSinhVien)
            {
                Console.WriteLine("Tên: {0}, Điểm: {1}",st.Name,st.Score);
            } 
                
            if (dsSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            Student thuKhoa = dsSinhVien[0];

            foreach (Student sv in dsSinhVien)
            {
                if (sv.Score > thuKhoa.Score)
                    thuKhoa = sv;
            }

            Console.WriteLine("\n----- SINH VIÊN CÓ ĐIỂM CAO NHẤT -----");
            Console.WriteLine($"Tên sinh viên: {thuKhoa.Name}");
            Console.WriteLine($"Điểm số: {thuKhoa.Score}");

            Console.ReadKey();
        }
    }
}
