using System;

namespace FairyTale.Exceptions
{
    class GoodEndException : Exception
    {
        public GoodEndException(string message) : base(message)
        {
        }
    }
}
