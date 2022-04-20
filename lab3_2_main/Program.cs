using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lab3_2_main
{
    class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
        }

        static void runMenu(List<Student> studs)
        {
            int choice;
            do
            {
                Console.WriteLine("Введіть 1 для виконання варіанту 12 студента Віталія Зьомши\n" +
                    "Введіть 2 для виконання варіанту 13 студента Артема Смотрителя\n" +
                    "Введіть 0 для закінчення роботи");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Var12.DoVar12(studs);
                        break;
                    case 2:
                        Var13.DoVar13(studs);
                        break;
                    default:
                        Console.WriteLine("Введено не коректний варіант. Повторіть спробу");
                        break;
                }
            } while (choice != 0);
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);            
        }
    }
}
