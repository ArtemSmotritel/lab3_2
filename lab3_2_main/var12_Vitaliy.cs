using System;

namespace lab3_2_main
{
    class Var12
    {
        static void DoVar12(Student[] studs)
        {
            double avgScholarship = 0;
            int n = 0;
            for (int i = 0; i <= studs.Length; i++)
            {
                if (studs[i].scholarship != 0)
                {
                    avgScholarship += studs[i].scholarship;
                    n++;
                }
            }
            if (n == 0) Console.WriteLine("Таких студентів немає");
            else
            {
                avgScholarship /= n;
                Console.WriteLine("Середня стипендія " + avgScholarship);
                Console.WriteLine("Студенти стипендія яких більш ніж на 20% менша середньої");
                for (int i = 0; i <= studs.Length; i++)
                {
                    if (studs[i].scholarship != 0 && studs[i].scholarship < avgScholarship * 0.8)
                    {
                        Console.WriteLine(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                }
            }
        }
    }
}
