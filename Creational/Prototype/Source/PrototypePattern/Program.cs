using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prototype1 p1 = new Prototype1(1);
            //Prototype1 c1 = (Prototype1)p1.Clone();
            //WriteLine($"Cloned  : {c1.Id}");

            //Prototype2 p2 = new Prototype2(2);
            //Prototype2 c2 = (Prototype2)p2.Clone();
            //WriteLine($"Cloned  : {c2.Id}");


            var superMarket = new SuperMarket();
            superMarket.AddProduct("Milk", new Milk(50.05M));
            superMarket.AddProduct("Bread", new Bread(15.5M));

            var milk = superMarket.GetProduct("Milk");
            var bread = superMarket.GetProduct("Bread");
            WriteLine($"Added Products : {milk.GetType().Name} and price : {milk.Price}");
            WriteLine($"Added Products : {bread.GetType().Name} and price : {bread.Price}");

            ReadKey();
        }
    }

    #region theory

    public abstract class Prototype
    {
        public int Id { get; set; }
        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }

    public class Prototype1 : Prototype
    {
        public Prototype1(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class Prototype2 : Prototype
    {
        public Prototype2(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    #endregion

    public class SuperMarket
    {
        Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

        public void AddProduct(string key, ProductPrototype product)
        {
            _productList.Add(key, product);
        }

        public ProductPrototype GetProduct(string key)
        {

            return (ProductPrototype)_productList[key].Clone();
        }
    }
}
