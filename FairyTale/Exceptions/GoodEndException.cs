using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale.Exceptions
{
    class GoodEndException : Exception
    {
        public GoodEndException(string message) : base(message)
        {
        }
    }
}
