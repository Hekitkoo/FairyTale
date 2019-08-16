using System;
using System.Collections.Generic;
using System.Linq;

namespace FairyTale
{
    /// <summary>
    /// One of the main story characters
    /// </summary>
    class Glove : StoryObject, IMainStoryObject
    {
        // default ctor
        public Glove()
        {
            Objects = new List<StoryObject>();
        }
        // prop
        public ICollection<StoryObject> Objects { get; set; }
        public override string Name => "Рукавичка";
        public override int Size => 200;
        public override string HowMove { get; set; }

        public override void Action(IMainStoryObject mainStoryObject)
        {
            Console.WriteLine($"Шёл {mainStoryObject.ToString().Split('.').Last()} лесом, шёл да и оборонил объект типа {this.Name}");
        }
        public void DoPlotTwist()
        {
            var _size = Objects.Sum(o => o.Size);
            // throw when gloves size < all size character who in gloves.
            if (Size < _size)
                throw new Exceptions.MainCharacterOverflowException($"{this.Name} взорвалась, никто не выжил.");
            else
                throw new Exceptions.GoodEndException("Неожиданный хороший конец.");
        }


    }
}
