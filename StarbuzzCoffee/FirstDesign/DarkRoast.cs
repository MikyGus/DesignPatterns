using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.FirstDesign
{
    public class DarkRoast : Beverage
    {
        public override string Title { get; } = "Dark Roast";
        public override string Description { get; } = "A roast in the dark";

        public override decimal Cost()
        {
            return 11.99M;
        }
    }
}
