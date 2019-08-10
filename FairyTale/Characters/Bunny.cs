using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    /// <summary>
    ///  it's a bunny(not main character)
    /// </summary>
    class Bunny : AbstractStoryObject
    {
        public Bunny()
        {
            Name = "Зайчик побегайчик";
            Size = 30;
            HowMove = "прыг-прыг";

        }
        public override string Name { get; set; }
        public override int Size { get; set; }
        public override string HowMove { get; set; }
    }
}
