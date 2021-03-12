using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerancaExFixacao5.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public string PriceTag()
        {
            return Name
                        + " $ "
                        + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                        + " (Customs fee: $ "
                        + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                        + ")";
        }

    }
}
