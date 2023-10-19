using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_DataProcessPractice
{
    public class Product
    {
        private string name;
        public string Name { get=>name; set { if (Validation.isFilled(value)) { name = value; }; } }

        private string description;
        public string Description { get => description; set { if (Validation.isFilled(value)) { description = value; }; } }

        private double price;
        public double Price { get=>price; set { if (Validation.isPositive(value)) { price = value; }; } }
        public Image ProductImage { get; set; }

        public static Product GetProduct(string name,string desc,double price)
        {
            return new Product { Name=name, Description=desc, Price=price };
        }

    }
}
