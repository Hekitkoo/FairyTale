using System;
using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    ///  Half main character;
    /// </summary>
    class Bear : StoryObject, IMainStoryObject
    {
        // Объявляем делегат
        public delegate void CustomEvent(string message);
        // Событие, возникающее Выборе медведя
        public event CustomEvent BearAttacked;
        // Событие, возникающее при выводе денег
        public event CustomEvent BearNoAttacked;

        // bear choise
        bool _badBoy = false;
        public override string Name => "Медведь верующий";
        public override int Size => 120;
        public override void Action(IMainStoryObject mainStoryObject)
        {
            BearAttacked += ShowMessage;
            BearNoAttacked += ShowMessage;
            if (mainStoryObject is StoryObject)
            {

                Console.WriteLine($"Красивая {(mainStoryObject as StoryObject).Name}.");
                if (_badBoy)
                {
                    BearAttacked($"Мне плевать, я медведь, паркуюсь(захожу) где хочу.");
                }
                else
                {
                    BearNoAttacked("Я хороший медведь, я не влезу, удачи Вам.");
                }
            }
        }
        public bool Choise { set { _badBoy = value; } }

        public ICollection<StoryObject> Objects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DoPlotTwist()
        {
            Console.WriteLine("Test");
        }
    }
}
