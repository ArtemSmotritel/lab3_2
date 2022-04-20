using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace lab3_2_main
{
    class Program
    {
        static List<Student> ReadData(string fileName)
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                students.Add(new Student(line));
                line = sr.ReadLine();
            }
            return students;
        }

        static void RunMenu(List<Student> students)
        {
            
        }

        static void Main(string[] args)
        {
            List<Student> students = ReadData("input.txt");
            RunMenu(students);
        }
    }
}
