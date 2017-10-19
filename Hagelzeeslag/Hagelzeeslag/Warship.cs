using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagelzeeslag
{
    public abstract class Warship
    {
        protected int lives;

        public bool IsSunk()
        {
            return !(lives > 0);
        }
    }
}
