using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public class Soy : CondimentDecorator
    {
        readonly Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + " +Soy";

        public override decimal Cost
        {
            get
            {
                return beverage.Size switch
                {
                    ESize.TALL => beverage.Cost + .10M,
                    ESize.GRANDE => beverage.Cost + .15M,
                    ESize.VENTI => beverage.Cost + .20M,
                    _ => beverage.Cost + .10M,
                };
            }
        }
    }
}
