using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        public class Student
        {
            Dictionary<string, int> studentMap = new Dictionary<string, int>();
            public Student()
            {
                this.studentMap = new Dictionary<string, int>();
            }

            public void PrintStudent()
            {

                foreach (var pair in this.studentMap)
                {
                    Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
                }
            }

            public void AddStudent(int age, string name)
            {
                if (this.studentMap.ContainsKey(name))
                {
                    Console.WriteLine($"Student Already Exists");
                }
                else
                {
                    this.studentMap.Add(name, age);
                    Console.WriteLine($"Student Added");
                }
            }
            public void RemoveStudent(string name)
            {
                if (studentMap.ContainsKey(name))
                {
                    studentMap.Remove(name);
                    Console.WriteLine($"Student Removed");
                }
                else
                    Console.WriteLine("student doesn't exist");

            }
            public Dictionary<string, int> GetStudentMap() { return studentMap; }
        }

    }
}
