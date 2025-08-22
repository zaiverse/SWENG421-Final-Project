using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class HatBuilder : BuilderIF
    {
        Hats hat = new Hats();

        public void setColor(String color)
        {
            hat.color = color;
        }

        public Hats getProduct()
        {
            return hat;
        }
    }
}
