using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public class Espresso : Beverage
    {
        public override string Description { get => Size + "Espresso"; }
        public override decimal Cost
        {
            get
            {
                return Size switch
                {
                    BeverageSize.TALL => 11.99M,
                    BeverageSize.GRANDE => 13.99M,
                    BeverageSize.VENTI => 15.99M,
                    _ => 11.99M,
                };
            }
        }
    }
}
