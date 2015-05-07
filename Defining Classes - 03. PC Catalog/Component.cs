using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___03.PC_Catalog
{
    class Component
    {
        private string name;
        private double price;
        public Component()
        {
        }
        public Component(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("INVALID COMPONENT NAME");
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) throw new Exception("INVALID COMPONENT PRICE");
                this.price = value;
            }
        }
    }
}
