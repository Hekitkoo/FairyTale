using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale.Characters
{
    class MainCharacterOverflowException : Exception
    {

        public MainCharacterOverflowException(string message) : base(message)
        {
        }
    }
}
