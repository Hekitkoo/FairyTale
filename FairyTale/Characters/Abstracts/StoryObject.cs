using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    /// <summary>
    /// Abstract class for all characters
    /// </summary>
    abstract class StoryObject
    {

        public abstract string Name { get; set; }

        public abstract int Size { get; set; }

        public virtual string HowMove { get; set; } = "бежит";

        public virtual void Action(IMainStoryObject mainStoryObject)
        {
            if (mainStoryObject.Objects.Count == 0)
                Console.WriteLine("Тут я буду жить.");
            else
                Console.WriteLine($"Кто, кто в объекте типа {(mainStoryObject as StoryObject).Name} живет?");
        }

    }
}
