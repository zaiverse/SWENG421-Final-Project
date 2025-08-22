using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class ByDesign: FilterABS
    {
        private String designToFilter;

        public ByDesign(List<ProductABS> productsToFilter, String design) : base(productsToFilter)
        {
            designToFilter = design;
        }

        public override List<ProductABS> getData()
        {
            // Filter ProductDecorator instances based on design name
            return products.OfType<ProductDecorator>()
                           .Where(p => p.design.designName.Equals(designToFilter, StringComparison.OrdinalIgnoreCase))
                           .Cast<ProductABS>() // Cast back to ProductABS if necessary
                           .ToList();
        }
    }
}
