using System;
using System.Collections.Generic;

namespace lab3_2_main
{
    class Var12
    {
        static double FindAvgScholarship (List<Student> students)
        {
            double sumScholarship = 0;
            int n = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].scholarship != 0)
                {
                    sumScholarship += students[i].scholarship;
                    n++;
                }
            }
            return sumScholarship / n;
        }
        static void LessScholarshipStudents(List<Student> students, double avgScholarship)
        {
            Console.WriteLine("Студенти з стипендією більш ніж на 20% менше середньої");
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].scholarship != 0 && students[i].scholarship < avgScholarship * 0.8)
                {
                    Console.WriteLine(students[i].surName + " " + students[i].firstName + " " + students[i].patronymic);
                }
            }
        }
        public static void DoVar12(List<Student> students)
        {
            double avgScholarship = FindAvgScholarship(students);
            if (!double.IsNaN(avgScholarship))
            {
                Console.WriteLine("Середня стипендія " + avgScholarship);
                LessScholarshipStudents(students, avgScholarship);
            }
            else Console.WriteLine("Ніхто не отримує стипендію");
        }
    }
}
