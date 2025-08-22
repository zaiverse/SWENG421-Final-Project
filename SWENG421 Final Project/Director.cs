using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class Director
    {
        public ProductABS makeShirt(ShirtBuilder s, String color)
        {
            s.setColor(color);
            return s.getProduct();
        }

        public ProductABS makePants(JeansBuilder j, String color)
        {
            j.setColor(color);
            return j.getProduct();
        }

        public ProductABS makeHats(HatBuilder h, String color)
        {
            h.setColor(color);
            return h.getProduct();
        }
    }
}
