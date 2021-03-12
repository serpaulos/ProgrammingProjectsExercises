using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerancaExFixacao5.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag()
        {
            return Name
               + " $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
