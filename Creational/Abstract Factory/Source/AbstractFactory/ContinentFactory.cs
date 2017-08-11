using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AbstractFactory
{
    public abstract class ContinentFactory
    {
        public abstract Carnivore CarnivoreAnimal();
        public abstract Herbivore HerbivoreAnimal();
    }

    public class AfricanFactory : ContinentFactory
    {
        public override Carnivore CarnivoreAnimal()
        {
            return new Lion();
        }

        public override Herbivore HerbivoreAnimal()
        {
            return new Wildebeast();
        }
    }

    public class AmericanFactory : ContinentFactory
    {
        public override Carnivore CarnivoreAnimal()
        {
            return new Wolf();
        }

        public override Herbivore HerbivoreAnimal()
        {
            return new Bison();
        }
    }

    public abstract class Herbivore { }

    public class Wildebeast: Herbivore { }

    public class Bison : Herbivore { }

    public abstract class Carnivore
    {
        public abstract void Eats(Herbivore animal);
    }

    public class Lion : Carnivore
    {
        public override void Eats(Herbivore animal)
        {
            WriteLine((this.GetType()).Name + " eats " + (animal.GetType()).Name);
        }
    }

    public class Wolf : Carnivore
    {
        public override void Eats(Herbivore animal)
        {
            WriteLine((this.GetType()).Name + " eats " + (animal.GetType()).Name);
        }
    }

}
