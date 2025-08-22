using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    abstract class FilterABS
    {
        protected List<ProductABS> products = null;

        public FilterABS(List<ProductABS> productstoFilter)
        {
            products = productstoFilter;
        }

        public abstract List<ProductABS> getData();

    }
}
