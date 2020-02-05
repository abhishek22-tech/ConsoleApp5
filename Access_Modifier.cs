using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
class Car3
{
    public string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car3 myObj = new Car3();
        Console.WriteLine(myObj.model);
    }
}
}
