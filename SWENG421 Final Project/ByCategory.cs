using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class ByCategory: FilterABS
    {
        private String categoryToFilter;

        public ByCategory(List<ProductABS> productsToFilter, String category) : base(productsToFilter)
        {
            categoryToFilter = category;
        }

        public override List<ProductABS> getData()
        {
            // Filter ProductABS instances based on category
            return products.Where(p => p.category.Equals(categoryToFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
