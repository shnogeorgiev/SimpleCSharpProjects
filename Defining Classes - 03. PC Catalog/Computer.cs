using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___03.PC_Catalog
{
    class Computer : Component
    {
        private string name;
        private Component componentone;
        private Component componenttwo;
        private Component componentthree;
        private bool hasComponends;
        private double price;
        private string output;

        public Computer(string name)
        {
            this.Name = name;
            this.hasComponends = false;
            this.Price = this.price;
            this.Output = this.output;
        }
        public Computer(string name, Component componentOne, Component componentTwo, Component componentThree) : this(name)
        {
            this.ComponentOne = componentone;
            this.ComponentTwo = componenttwo;
            this.ComponentThree = componentthree;
            this.hasComponends = true;
            this.Price = price;
            this.Output = output;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null) throw new Exception("Invalid PC Name!!");
                this.name = value;
            }
        }
        public Component ComponentOne { get; set; }
        public Component ComponentTwo { get; set; }
        public Component ComponentThree { get; set; }
        public double Price
        {
            get
            {
                double sum = ComponentOne.Price + ComponentTwo.Price + ComponentThree.Price;
                return sum;
            }
            set
            {
                if (value < 0) throw new Exception("INVALID PRICE VALUE");
                this.price = value;
            }
        }
        public string Output
        {
            get
            {
                this.output = "\nComputer Name: " + this.Name;
                return this.output;
            }
            set
            {
                if (hasComponends)
                {
                    value += "\nComponent One Name: " + this.ComponentOne.Name + "Component One Price: " + this.ComponentOne.Price;
                    value += "\nComponent Two Name: " + this.ComponentTwo.Name + "Component Two Price: " + this.ComponentTwo.Price;
                    value += "\nComponent Three Name: " + this.ComponentThree.Name + "Component Three Price: " + this.ComponentThree.Price;
                    value += string.Format("\nTOTAL PRICE: {0:f2}BGN", this.Price);
                }
                else
                {
                    value += "\nTOTAL PRICE: 100.00 BGN";
                }
                this.output = value;
            }
        }
    }
}
