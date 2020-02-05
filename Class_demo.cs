using System;

namespace ConsoleApp5
{
    class Car 
    {
        //Creating class and multiple objects
        string color = "red";

        public static void Main(string[] args)
        {

            Car myobj = new Car();
            Car myobj1 = new Car();
            Console.WriteLine(myobj.color);
            Console.WriteLine(myobj1.color);
        }
            
    }
}
