﻿namespace _0705._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counterEntrance = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentInfo = new();

            for (int i = 0; i < counterEntrance; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentInfo.ContainsKey(studentName))
                {
                    studentInfo.Add(studentName, new List<double>());
                }
                studentInfo[studentName].Add(studentGrade);
            }

            foreach (var student in studentInfo)
            {
                if (student.Value.Average() >= 4.50)
                {
                    double averageGrade = student.Value.Average();
                    Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
                }
            }
            //var result = studentInfo.Where(st => st.Value.Average() >= 4.5);
            //foreach (var item in result)
            //{
            //    double averageGrade = item.Value.Average();
            //    Console.WriteLine($"{item.Key} -> {averageGrade:F2}");
            //}
        }
    }
}
