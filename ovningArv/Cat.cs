using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovningArv
{
   internal class Cat : Feline
    {
        public override int GetMaximumSpeed()
        {
            return 3;
        }

        public override string GetSound()
        {
            return "Mjau";
        }
    }
}
