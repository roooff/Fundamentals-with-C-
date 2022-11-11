namespace _5._Courses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Course name
            // Key-> Value
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();
            string commnad;
            while ((commnad = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = commnad.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                coursesInfo[courseName].Add(studentName);
            }
            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}