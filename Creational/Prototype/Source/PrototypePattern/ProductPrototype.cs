namespace PrototypePattern
{
    public abstract class ProductPrototype
    {
        public decimal Price { get; set; }

        public ProductPrototype(decimal price)
        {
            Price = price;
        }

        public abstract ProductPrototype Clone();
    }

    public class Milk : ProductPrototype
    {
        public Milk(decimal price) : base(price)
        {
        }

        public override ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }
    }

    public class Bread : ProductPrototype
    {
        public Bread(decimal price) : base(price)
        {
        }

        public override ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }
    }
}
