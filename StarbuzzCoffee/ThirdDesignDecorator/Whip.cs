using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public class Whip : CondimentDecorator
    {
        readonly Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + " +Whip";

        public override decimal Cost
        {
            get
            {
                return beverage.Size switch
                {
                    ESize.TALL => beverage.Cost + .50M,
                    ESize.GRANDE => beverage.Cost + .60M,
                    ESize.VENTI => beverage.Cost + .70M,
                    _ => beverage.Cost + .50M,
                };
            }
        }
    }
}
