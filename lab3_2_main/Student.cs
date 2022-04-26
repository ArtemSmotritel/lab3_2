using System;
using System.Text;
using System.Linq;

namespace lab3_2_main
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] separatedData = lineWithAllData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            surName = separatedData[0];
            firstName= separatedData[1];
            patronymic= separatedData[2];
            sex = char.Parse(separatedData[3]);
            dateOfBirth = separatedData[4];
            mathematicsMark = char.Parse(separatedData[5]);
            physicsMark= char.Parse(separatedData[6]);
            informaticsMark= char.Parse(separatedData[7]);
            scholarship = int.Parse(separatedData[8]);
        }
    }
}
