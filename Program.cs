using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.Make = "Ford";
            MyCar.Model = "F-150";
            MyCar.Year = 2018;

            Console.WriteLine($"{MyCar.Make}, {MyCar.Model}, {MyCar.Year}");
        }
    }
}
