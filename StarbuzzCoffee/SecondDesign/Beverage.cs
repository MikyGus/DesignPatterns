using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.SecondDesign
{
    public abstract class Beverage
    {
        abstract public string Title { get; }
        abstract public string Description { get; }
        public bool Milk { get; set; }
        public bool Soy { get; set; }
        public bool Mocha { get; set; }
        public bool Whip { get; set; }
        public virtual decimal Cost()
        {
            decimal output = 0M;
            if (Milk) output += 2M;
            if (Soy) output += 4M;
            if (Mocha) output += 5M;
            if (Whip) output += 3M;
            return output;
        }



    }
}
