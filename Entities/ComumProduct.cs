using System;
namespace Product.Entities
{
    public class ComumProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ComumProduct()
        {
        }

        public ComumProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
}
