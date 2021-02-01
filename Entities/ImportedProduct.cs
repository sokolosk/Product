using System;
namespace Product.Entities
{
    public class ImportedProduct : ComumProduct
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + " (CustomsFee: $ " + CustomsFee.ToString("F2") + ")";
        }

        
    }
}
