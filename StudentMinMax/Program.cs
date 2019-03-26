using System;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            foreach (var student in students)
            {
                //test
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
        }
    }
}