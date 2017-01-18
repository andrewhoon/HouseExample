using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExample
{
    class House  //I right clicked on the name on the right (second one down, not solution)
    {
        string color;                                   //these are fields
        int rooms;
        public double squareFeet;
        public string metroArea;
        private string name;

        public string Name                 //properties
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //    public House (string color, int rooms)
        //{
        //    this.color = color;
        //    this.rooms = rooms;
        //}

        public House(string color, int rooms, double squareFeet, string metroArea)
        {
            this.color = color;
            this.rooms = rooms;
            this.squareFeet = squareFeet;
            this.metroArea = metroArea;


        }
        public void DisplayHouseInfo()
        {
            Console.Write("The color of this house is " + color);
            Console.Write(", the number of rooms is " + rooms);
            Console.Write(", the square footage is " + squareFeet);
            Console.WriteLine(", the metro area is in " + metroArea + ".");


            //}

            //public void Paint(string color)                         //method (no longer need static, since it is in clear class
            //{                                                       //getting color
            //    this.color = color;
            //}

            //public string CurrentColor()
            //{                                                               //returning color method. 
            //    return color;
            //}








        }
    }
}

