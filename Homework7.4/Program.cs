using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of students");
            int number = int.Parse(Console.ReadLine());
            int[] students = new int[number];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = rnd.Next(130, 220);
                Console.WriteLine($"student{i+1} = {students[i]}");
            }
            int sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum +=  students[i];
            }
            int avarage = sum/number;
            Console.WriteLine($"Average height = {avarage}");
        }
    }
}
