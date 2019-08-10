using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    /// <summary>
    /// One of the main story characters
    /// </summary>
    class Glove : AbstractStoryObject, IMainStoryObject
    {
        // default ctor
        public Glove()
        {
            Name = "Рукавичка";
            Size = 200;
            Objects = new List<AbstractStoryObject>();
        }
        // Custom ctor
        public Glove(string name, int size)
        {
            Name = name;
            Size = size;
        }
        // prop
        public ICollection<AbstractStoryObject> Objects { get; set; }

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
                throw new Characters.MainCharacterOverflowException($"{this.Name} взорвалась, никто не выжил.");
            else
                throw new Exceptions.GoodEndException("Неожиданный хороший конец.");
        }


    }
}
