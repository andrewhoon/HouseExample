using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExample
{
    class House  //I right clicked on the name on the right (second one down, not solution)
    {
        private string color;                                   //these are fields
        private int rooms;           
        double squareFeet;
        string metroArea;
        static private int avgHousePrice;


        public void Paint(string color)                         //method (no longer need static, since it is in clear class
        {                                                       //getting color
            this.color = color;
        }

        public string CurrentColor()
        {                                                               //returning color method. 
            return color;
        }
      






    }
}
