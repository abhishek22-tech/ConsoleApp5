using System;

namespace Exercise4
{
    class Car1
{
        string color;
        string model;
        int year;

        private static void Main(string[] args)
        {
            Car1 ford = new Car1();
            ford.model = "mustang";
            ford.color = "blue";
            ford.year = 1994;

            Car1 tesla = new Car1();
            tesla.color = "red";
            tesla.model = "s";
            tesla.year = 2009;

            Console.WriteLine("model of ford is " +ford.model);
            Console.WriteLine("year of ford is " +ford.year);

            Console.WriteLine("year of tesla is " + tesla.year);
            Console.WriteLine("model of tesla is" + tesla.model);
        }
}
}
