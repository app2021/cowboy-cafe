using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public override bool Ice { get; set; } = false;

        public override double Price => throw new NotImplementedException();

        public override uint Calories => throw new NotImplementedException();

        public override List<string> SpecialInstructions => throw new NotImplementedException();
    }
}
