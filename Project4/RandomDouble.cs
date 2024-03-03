using System;

namespace Project4
{
    class RandomDouble : RandomType<double>
    {
        public override double Generate()
        {
            return random.NextDouble();
        }
    }
}