using System;
using System.Collections.Generic;

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
            Name = "Рукавичка";
            Size = 200;
            Objects = new List<StoryObject>();
        }
        // Custom ctor
        public Glove(string name, int size)
        {
            Name = name;
            Size = size;
        }
        // prop
        public ICollection<StoryObject> Objects { get; set; }

        public override string Name { get; set; }
        public override int Size { get; set; }
        public override string HowMove { get; set; }

        public override void Action(IMainStoryObject mainStoryObject)
        {
            throw new NotImplementedException();
        }

        public void DoPlotTwist()
        {
            int _size = default(int);
            foreach (var item in Objects)
            {
                _size += item.Size;
            }
            // throw when gloves size < all size character who in gloves.
            if (Size < _size)
                throw new Exceptions.MainCharacterOverflowException ($"{this.Name} взорвалась, никто не выжил.");
            else
                throw new Exceptions.GoodEndException("Неожиданный хороший конец.");
        }


    }
}
