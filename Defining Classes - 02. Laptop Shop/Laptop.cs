using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___02.Laptop_Shop
{
    class Laptop
    {
        //Fields
        private string model;
        private double price;
        private string manufac;
        private string proc;
        private string ram;
        private string graphics;
        private string hdd;
        private string screen;
        private string battery;
        private string batteryLife;
        //Constructors
        //#0
        public Laptop(string model, double price, string battery, string batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }
        //#1
        public Laptop(string model, double price, string battery, string batteryLife, string manufac)
            : this(model, price, battery, batteryLife)
        {
            this.Manufac = manufac;
        }
        //#2
        public Laptop(string model, double price, string battery, string batteryLife, string manufac, string proc)
            : this(model, price, battery, batteryLife, manufac)
        {
            this.Proc = proc;
        }
        //#3
        public Laptop(string model, double price, string battery, string batteryLife, string manufac, string proc, string ram)
            : this(model, price, battery, batteryLife, manufac, proc) 
        {
            this.Ram = ram;
        }
        //#4
        public Laptop(string model, double price, string battery, string batteryLife, string manufac, string proc, string ram, string graphics)
            : this(model, price, battery, batteryLife, manufac, proc, ram)
        {
            this.Graphics = graphics;
        }
        //#5
        public Laptop(string model, double price, string battery, string batteryLife, string manufac, string proc, string ram, string graphics, string hdd)
            : this(model, price, battery, batteryLife, manufac, proc, ram, graphics)
        {
            this.HDD = hdd;
        }
        //#6
        public Laptop(string model, double price, string battery, string batteryLife, string manufac, string proc, string ram, string graphics, string hdd, 
            string screen) : this(model, price, battery, batteryLife, manufac, proc, ram, graphics, hdd)
        {
            this.Screen = screen;
        }
        //Properties
        //Model Property//
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid model !");
                this.model = value;
            }
        }
        //Price Property//
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) throw new Exception("Invalid price !");
                this.price = value;
            }
        }
        //Manufac Property//
        public string Manufac
        {
            get
            {
                return this.manufac;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length == 0) throw new Exception("Invalid value !");
                this.manufac = value;
            }
        }
        //Proc Property//
        public string Proc
        {
            get
            {
                return this.proc;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.proc = value;
            }
        }
        //RAM Property//
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.ram = value;
            }
        }
        //Graphics Property//
        public string Graphics
        {
            get
            {
                return this.graphics;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.graphics = value;
            }
        }
        //HDD Property//
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.hdd = value;
            }
        }
        //Screen Property//
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.screen = value;
            }
        }
        //Battery Property//
        public string Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.battery = value;
            }
        }
        //BatteryLife Property//
        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0) throw new Exception("Invalid value !");
                this.batteryLife = value;
            }
        }
        //Display Method
        public override string ToString()
        {
            string OUTPUT = "MODEL: " + this.Model;
            OUTPUT += "\nPRICE: " + this.Price;
            if (this.Manufac != null)
                OUTPUT += "\nMANUFAC: " + this.Manufac;
            if (this.Proc != null)
                OUTPUT += "\nPROC: " + this.Proc;
            if (this.Ram != null)
                OUTPUT += "\nRAM " + this.Ram;
            if (this.Graphics != null)
                OUTPUT += "\nGRAPHICS: " + this.Graphics;
            if (this.HDD != null)
                OUTPUT += "\nHDD " + this.HDD;
            if (this.Screen != null)
                OUTPUT += "\nSCREEN: " + this.Screen;
            if (this.Battery != null)
                OUTPUT += "\nBATTERY: " + this.Battery;
            if (this.BatteryLife != null)
                OUTPUT += "\nBATTERY LIFE " + this.BatteryLife + "\n";
            return OUTPUT;
        }
    }
}
