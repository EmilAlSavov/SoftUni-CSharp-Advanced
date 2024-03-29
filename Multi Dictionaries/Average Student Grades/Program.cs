﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal> { grade});
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key} -> {PrintList(student.Value)}(avg: {(student.Value.Average()) :F2})");
            }
        }

        public static string PrintList(List<decimal> list)
        {
            string result = string.Empty;
            foreach (var item in list)
            {
                result += ($"{item:F2} ");
            }
            return result;
        }
    }
}
