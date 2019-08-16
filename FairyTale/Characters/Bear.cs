using System;

namespace FairyTale
{
    /// <summary>
    ///  Half main character;
    /// </summary>
    class Bear : StoryObject
    {
        // bear choise
        bool _badBoy;
        public override string Name => "Медведь верующий";
        public override int Size => 120;
        public override void Action(IMainStoryObject mainStoryObject)
        {
            if (mainStoryObject is StoryObject)
            {
                Console.WriteLine($"Красивая {(mainStoryObject as StoryObject).Name}.");
                if (_badBoy)
                    Console.WriteLine($"Мне плевать, я медведь, паркуюсь(захожу) где хочу.");
                else
                    Console.WriteLine("Я хороший медведь, я не влезу, удачи Вам.");
            }
        }
        public bool Choise { set { _badBoy = value; } }
    }
}
