using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovningArv
{
    internal abstract class Animal
    {
        internal string Name { get; set; }
        internal int Weight { get; set; }

        public abstract string GetSound();
    }
}
