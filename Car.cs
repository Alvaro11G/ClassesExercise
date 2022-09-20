using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    public class Car
    {
        public Car()
        {

        }
        public Car (string makeInput, string modelInput, int year)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
        }


        //make property, model property, and year property
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
