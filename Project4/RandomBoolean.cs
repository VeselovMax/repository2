using System;

namespace Project4
{
    public class RandomBoolean : RandomType<bool>
    {
        public override bool Generate() {
            if (random.Next(0, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}