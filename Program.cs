using System;
using Balta.ContentContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();
            var career = new Career();

            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}