using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class WheelsDecorator : CarDecorator
    {
        public WheelsDecorator(Car car)
        : base(car) { }

        public override double Price()
        {
            return base.Price() + 5000.00;
        }
    }
}
