using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double Price()
        {
            return _car.Price();
        }
    }
}
