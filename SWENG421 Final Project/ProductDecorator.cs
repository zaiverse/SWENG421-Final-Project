using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class ProductDecorator : ProductABS
    {
        public ProductABS product { get; }
        public DesignABS design { get; }

        public ProductDecorator(ProductABS product, DesignABS design)
        {
            this.product = product;
            this.design = design;
        }

        public override string ToString()
        {
            return $"{product.ToString()} w/ {design.designName}";
        }

        public override double getPrice()
        {
            return product.getPrice() + design.getPrice();
        }
    }
}
