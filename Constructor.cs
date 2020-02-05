using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
   class Car2
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car2(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Main(string[] args)
    {
        Car2 Ford = new Car2("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}

}
