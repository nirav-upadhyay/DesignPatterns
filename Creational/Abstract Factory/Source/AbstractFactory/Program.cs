using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new Factory(new AudiFamilyCar(), new AudiSportCar());
            client.Execute();

            client = new Factory(new MercFamilyCar(), new MercSportCar());
            client.Execute();

            client = new Factory(new MercFamilyCar(), new AudiSportCar());
            client.Execute();

            client = new Factory(new AudiFamilyCar(), new lamborginiSportCar());
            client.Execute();

            Console.ReadKey();
        }

        public class Client
        {
            Herbivore _herbivore;
            Carnivore _carnivore;

            public Client(Herbivore h, Carnivore c)
            {
                _herbivore = h;
                _carnivore = c;
            }

            public void Execute()
            {
                _carnivore.Eats(_herbivore);
            }

        }

        public class Factory
        {
            FamilyCar _familyCar;
            SportCar _sportCar;

            public Factory(FamilyCar familyCar, SportCar sportCar)
            {
                _familyCar = familyCar;
                _sportCar = sportCar;
            }

            public void Execute()
            {
                _sportCar.Speed(_familyCar);
            }
        }
    }
}
