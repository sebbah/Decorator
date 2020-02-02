using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Mercedes : Car
    {
        public override double Price()
        {
            return 80000.00;
        }
    }
}
