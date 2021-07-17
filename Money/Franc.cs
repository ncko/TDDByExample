using System;

namespace Money
{
    public class Franc : IEquatable<Franc>
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }
        
        public Franc Times(int multiplier)
        {
            return new(_amount * multiplier);
        }

        public bool Equals(Franc other)
        {
            return other != null && _amount == other._amount;
        }

        public override int GetHashCode()
        {
            return _amount;
        }

        public override string ToString()
        {
            return $"${_amount}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Franc);
        }
    }
}