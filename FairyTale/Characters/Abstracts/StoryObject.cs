using System;

namespace FairyTale
{
    /// <summary>
    /// Abstract class for all characters
    /// </summary>
    abstract class StoryObject
    {
        public abstract string Name { get;}
        public abstract int Size { get;}
        public virtual string HowMove { get; set; } = "бежит";
        public virtual void Action(IMainStoryObject mainStoryObject)
        {
            if (mainStoryObject.Objects.Count != 0)
                if (mainStoryObject is StoryObject)
                {
                    Console.WriteLine($"Кто, кто в объекте типа {(mainStoryObject as StoryObject).Name} живет?");
                }
                else
                {
                    Console.WriteLine("Тут я буду жить.");
                }
        }
    }
}
