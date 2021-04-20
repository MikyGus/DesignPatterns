using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.FirstDesign
{
    public class HouseBlend : Beverage
    {
        public override string Title { get; } = "House Blend";
        public override string Description { get; } = "A blending house";

        public override decimal Cost()
        {
            return 12.50M;
        }
    }
}
