using System;
using System.Collections.Generic;

namespace lab3_2_main
{
    class Var12
    {
        static void DoVar12(List<Student> students)
        {
            double avgScholarship = 0;
            int n = 0;
            for (int i = 0; i <= students.Count; i++)
            {
                if (students[i].scholarship != 0)
                {
                    avgScholarship += students[i].scholarship;
                    n++;
                }
            }
            if (n == 0) Console.WriteLine("Таких студентів немає");
            else
            {
                avgScholarship /= n;
                Console.WriteLine("Середня стипендія " + avgScholarship);
                Console.WriteLine("Студенти стипендія яких більш ніж на 20% менша середньої");
                for (int i = 0; i <= students.Count; i++)
                {
                    if (students[i].scholarship != 0 && students[i].scholarship < avgScholarship * 0.8)
                    {
                        Console.WriteLine(students[i].surName + " " + students[i].firstName + " " + students[i].patronymic);
                    }
                }
            }
        }
    }
}
