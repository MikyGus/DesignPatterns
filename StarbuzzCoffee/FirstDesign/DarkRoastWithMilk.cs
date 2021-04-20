using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.FirstDesign
{
    public class DarkRoastWithMilk : Beverage
    {
        public override string Title { get; } = "Dark Roast with Milk";

        public override string Description { get; } = "A roast in the dark, with milk";

        public override decimal Cost()
        {
            return 11.99M + 4M;
        }
    }
}
