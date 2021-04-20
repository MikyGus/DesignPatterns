using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.FirstDesign
{
    public abstract class Beverage
    {
        abstract public string Title { get; }
        abstract public string Description { get; }

        abstract public decimal Cost();



    }
}
