using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class JeansBuilder : BuilderIF
    {
        private Jeans jean = new Jeans();

        public void setColor(String color)
        {
            jean.color = color;
        }

        public Jeans getProduct()
        {
            return jean;
        }
    }
}
