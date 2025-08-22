using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    abstract class DesignABS
    {
        public String designName { set; get; }
        public double price { set; get; }

        public DesignABS(String name, double p) 
        {
            designName = name;
            price = p;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
