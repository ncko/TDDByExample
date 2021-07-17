using System;

namespace Money
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar) obj;
            return dollar != null && Amount == dollar.Amount;
        }
    }
}