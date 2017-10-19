using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagelzeeslag
{
    public class Kruiser
    {
        private int lives;

        public Kruiser()
        {
            lives = 4;
        }

        public bool IsSunk()
        {
            return !(lives > 0);
        }
    }
}
