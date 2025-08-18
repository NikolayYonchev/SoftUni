using System;
using System.Linq;
using System.Collections.Generic;
/*
3
Mary Elizabeth 4.22
Li Xiao 5.74
Liz Smith 4.87



 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(name, secondName, grade);

                list.Add(student);

            }
            list = list.OrderByDescending(x => x.Grade).ToList();
            foreach (Student smt in list)
            {
                Console.WriteLine(smt.ToString());
            }
            // {
            //     Console.WriteLine(smt.ToString());
            // }
            // List<Student> list2 = new List<Student>();
            // double checker = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     
            //     if (list[i].Grade > checker)
            //     {
            //         list2.Add(list[i]);
            //         checker = list[i].Grade;
            //     }
            //     else
            //     {
            //         list2.Insert(i - 1, list[i]);
            //     }
            // }
            // list2.Reverse();
            // foreach (Student smt in list2)
            // {
            //     Console.WriteLine(smt.ToString());
            // }

        }


        public class Student
        {
            public string Name { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public Student(string title, string content, double grade)
            {
                Name = title;
                SecondName = content;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{Name} {SecondName}: {Grade:F2}";
            }

        }
    }
}