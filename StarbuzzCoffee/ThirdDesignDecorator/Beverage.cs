using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public abstract class Beverage : IBeverage
    {
        public BeverageSize Size { get; set; } = BeverageSize.TALL;
        public virtual string Description { get => "Unknown beverage"; }
        public virtual decimal Cost { get; } = 0M;
    }
}
