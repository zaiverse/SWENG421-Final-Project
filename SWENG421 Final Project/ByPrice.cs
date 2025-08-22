using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class ByPrice: FilterABS
    {
        private String priceToFilter;

        public ByPrice(List<ProductABS> productsToFilter, String price) : base(productsToFilter)
        {
            priceToFilter = price;
        }

        public override List<ProductABS> getData()
        {
            // Filter ProductABS instances based on price
            return products.Where(p => p.price.Equals(priceToFilter)).ToList();
        }
    }
}
