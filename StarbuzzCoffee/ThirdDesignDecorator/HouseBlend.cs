using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public class HouseBlend : Beverage
    {
        public override string Description { get => Size + " House Blend"; }

        public override decimal Cost
        {
            get
            {
                return Size switch
                {
                    ESize.TALL => 9.99M,
                    ESize.GRANDE => 11.99M,
                    ESize.VENTI => 13.99M,
                    _ => 9.99M,
                };
            }
        }
    }
}
