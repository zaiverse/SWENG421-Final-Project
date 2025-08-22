using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class ShirtBuilder : BuilderIF
    {
        private TShirt shirt = new TShirt();

        public void setColor(String color)
        {
            shirt.color = color;
        }

        public TShirt getProduct()
        {
            return shirt;
        }
    }
}
