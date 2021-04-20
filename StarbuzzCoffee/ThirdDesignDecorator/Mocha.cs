using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public class Mocha : CondimentDecorator
    {
        readonly Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + " +Mocha";

        public override decimal Cost
        {
            get
            {
                return beverage.Size switch
                {
                    BeverageSize.TALL => beverage.Cost + .30M,
                    BeverageSize.GRANDE => beverage.Cost + .40M,
                    BeverageSize.VENTI => beverage.Cost + .50M,
                    _ => beverage.Cost + .30M,
                };
            }
        }
    }
}
