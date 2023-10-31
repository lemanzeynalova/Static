using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Student
    {
        public static int nextId = 1;
        public int ID {  get; set; }
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }
        public Student(string fullname, string groupNo, int age)
        {
            ID = nextId++;
            Fullname = fullname;
            GroupNo = ValidateGroupNo(groupNo);
            Age = age;
        }

        private string ValidateGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]) && int.TryParse(groupNo.Substring(1), out int result))
            {
                return groupNo;
            }
            else
            {
                 new ArgumentException("Group number must consist of one uppercase letter followed by three digits (e.g., P101).");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Fullname: {Fullname}, GroupNo: {GroupNo}, Age: {Age}";
        }
    }

   
}

