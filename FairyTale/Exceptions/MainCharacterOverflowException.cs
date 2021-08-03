using System;

namespace FairyTale.Exceptions
{
    class MainCharacterOverflowException : Exception
    {
        public MainCharacterOverflowException(string message) : base(message)
        {
        }
    }
}
