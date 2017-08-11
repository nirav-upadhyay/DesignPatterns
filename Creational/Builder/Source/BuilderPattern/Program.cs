using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerShop computerShop = new ComputerShop();
            var mylappy = new LaptopBuilder();

            computerShop.ConstructComputer(mylappy);
            mylappy.Computer.DisplayConfiguration();

            var macBook = new AppleBuilder();

            computerShop.ConstructComputer(macBook);
            macBook.Computer.DisplayConfiguration();

            ReadKey();
        }
    }

    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildProcessor();
            computerBuilder.BuildRAM();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildMotherboard();
        }
    }

    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }
        public abstract void BuildProcessor();
        public abstract void BuildMotherboard();
        public abstract void BuildRAM();
        public abstract void BuildHardDisk();
    }

    public class Computer
    {
        public ComputerType _computerType;
        public string MotherBoard { get; set; }
        public string RAM { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public Computer(ComputerType computerType)
        {
            _computerType = computerType;
        }

        public void DisplayConfiguration()
        {
            WriteLine("--------------------");

            WriteLine("Configurations for current Computer are : ");

            WriteLine("Type : " + _computerType);

            WriteLine("MotherBoard : " + MotherBoard);

            WriteLine("HardDisk : " + HardDisk);

            WriteLine("RAM : " + RAM);

            WriteLine("Processor : " + Processor);

            WriteLine("--------------------");
        }
    }

    public enum ComputerType
    {
        Laptop,
        Desptop,
        Apple
    }

    public class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            Computer = new Computer(ComputerType.Laptop);
        }

        public override void BuildHardDisk()
        {
            Computer.HardDisk = "2TB SSD hard disk";
        }

        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Asus P68 Premium";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Intel i7";
        }

        public override void BuildRAM()
        {
            Computer.RAM = "4GB RAM";
        }
    }

    public class AppleBuilder : ComputerBuilder
    {
        public AppleBuilder()
        {
            Computer = new Computer(ComputerType.Apple);
        }

        public override void BuildHardDisk()
        {
            Computer.HardDisk = "2TB SSD Apple";
        }

        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Asus P68 Premium Apple";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Intel i7 Apple";
        }

        public override void BuildRAM()
        {
            Computer.RAM = "8GB RAM Apple";
        }
    }
}
