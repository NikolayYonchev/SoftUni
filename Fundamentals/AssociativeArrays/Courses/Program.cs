using System;
using System.Linq;
using System.Collections.Generic;
/*


 */
namespace Fundamentals
{
    public class Course
    {
        public Course(string name)
        {
            StudentsNames = new List<string>();
            Name = name;
        }

        public string Name { get; set; }

        public List<string> StudentsNames { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {StudentsNames.Count}\n";

            for (int i = 0; i < StudentsNames.Count; i++)
            {
                result += $"-- {StudentsNames[i]}\n";
            }

            return result.Trim();
        }
    }

    internal class Program
    {
        static void Main(string[] arguments)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argument = command.Split(" : ");

                string courseName = argument[0];
                string studentName = argument[1];

                if (!courses.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    courses.Add(courseName, course);
                }

                courses[courseName].StudentsNames.Add(studentName);
            }


            foreach (KeyValuePair<string, Course> pair in courses)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}