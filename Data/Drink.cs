using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        public virtual Size Size { get; set; }

        public abstract double Price { get; }


        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

        public virtual bool Ice { get; set; } = true;

    }
}
