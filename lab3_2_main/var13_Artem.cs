using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_2_main
{
    class Var13
    {
        private static List<string> SurnamesSkippedTwoAndMoreTests = new List<string>();
        private static void PrintStudentsSkippedTests()
        {
            Console.WriteLine("Прізвища студентів, які пропустили більше двох іспитів:");
            foreach (string surname in SurnamesSkippedTwoAndMoreTests)
            {
                Console.WriteLine(surname);
            }            
        }
        public static void DoVar13(Student[] students)
        {
            CheckSurnamesForTwoSkippedTests(students);
            if (SurnamesSkippedTwoAndMoreTests.Count == 0)            
                Console.WriteLine("Жоден студент не пропустив більше 2 іспитів");            
            else            
                PrintStudentsSkippedTests();            
        }
        private static void CheckSurnamesForTwoSkippedTests(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (StudentSkippedThree(students[i]))
                {
                    SurnamesSkippedTwoAndMoreTests.Add(students[i].surName);
                }
            }
        }
        private static bool StudentSkippedThree(Student student)
        {
            return student.informaticsMark == '-' && student.mathematicsMark == '-' && student.physicsMark == '-';
        }
    }
}
