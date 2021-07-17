using System;

namespace Money
{
    public class Dollar : IEquatable<Dollar>
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }
        
        public Dollar Times(int multiplier)
        {
            return new(_amount * multiplier);
        }

        public bool Equals(Dollar other)
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
            return Equals(obj as Dollar);
        }
    }
}