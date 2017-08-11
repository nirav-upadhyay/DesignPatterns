using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AbstractFactory
{
    public abstract class CarFactory
    {
        public abstract FamilyCar GetFamilyCar();
        public abstract SportCar GetSportCar();
    }

    public class MercFactory : CarFactory
    {
        public override FamilyCar GetFamilyCar()
        {
            return new MercFamilyCar();
        }

        public override SportCar GetSportCar()
        {
            return new MercSportCar();
        }
    }

    public class AudiFactory : CarFactory
    {
        public override FamilyCar GetFamilyCar()
        {
            return new AudiFamilyCar();
        }

        public override SportCar GetSportCar()
        {
            return new AudiSportCar();
        }
    }

    public abstract class FamilyCar
    {

    }

    public class MercFamilyCar: FamilyCar
    {

    }

    public class AudiFamilyCar : FamilyCar
    {

    }

    public class lamborginiSportCar : SportCar
    {
        public override void Speed(FamilyCar famCar)
        {
            WriteLine(GetType().Name + " is faster than " + famCar.GetType().Name);
        }
    }

    public abstract class SportCar
    {
        public abstract void Speed(FamilyCar famCar);
    }

    public class MercSportCar : SportCar
    {
        public override void Speed(FamilyCar famCar)
        {
            WriteLine(GetType().Name + " is faster than " + famCar.GetType().Name);
        }
    }

    public class AudiSportCar : SportCar
    {
        public override void Speed(FamilyCar famCar)
        {
            WriteLine(GetType().Name + " is faster than " + famCar.GetType().Name);
        }
    }
}
