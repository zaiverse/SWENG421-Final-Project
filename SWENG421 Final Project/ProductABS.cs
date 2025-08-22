using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    abstract class ProductABS
    {
        public String category { get; }
        public String color { get; set; }
        public double price { get; }

        public ProductABS() { }

        public ProductABS(String c, double p) {
            category = c;
            price = p;
        }
        public virtual double getPrice() { return price; }

        public override string ToString()
        {
                return $"{color} {category}";
        }
    }
}
