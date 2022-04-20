using System;
using System.Collections.Generic;

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
        public static void DoVar13(List<Student> students)
        {
            CheckSurnamesForTwoSkippedTests(students);
            if (SurnamesSkippedTwoAndMoreTests.Count == 0)            
                Console.WriteLine("Жоден студент не пропустив більше 2 іспитів");            
            else            
                PrintStudentsSkippedTests();            
        }
        private static void CheckSurnamesForTwoSkippedTests(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (StudentSkippedTwoMore(students[i]))
                {
                    SurnamesSkippedTwoAndMoreTests.Add(students[i].surName);
                }
            }
        }
        private static bool StudentSkippedTwoMore(Student student)
        {
            return student.informaticsMark == '-' && student.mathematicsMark == '-' && student.physicsMark == '-';
        }
    }
}
