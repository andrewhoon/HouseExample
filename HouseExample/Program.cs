using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();           //creating new house.  storing it as houseOne.

            house1.Paint("Green");
            Console.WriteLine(house1.CurrentColor());  //CurrentColor is method in House.cs

            House house2 = new House();
            house2.Paint("Blue");
            Console.WriteLine("House One is " + house1.CurrentColor() + " and House two is " + house2.CurrentColor() + ".");

            Console.WriteLine("I've got a house");






        }
    }
}
