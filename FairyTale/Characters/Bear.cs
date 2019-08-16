using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Bear : StoryObject
    {
        /// <summary>
        ///  Half main character;
        /// </summary>
        public Bear()
        {
            Name = "Медведь верующий";
            Size = 120;
        }
        // bear choise
        bool _goodOrBadBoy;
        public override string Name { get; set; }
        public override int Size { get; set; }
        public override void Action(IMainStoryObject mainStoryObject)
        {
            if (_goodOrBadBoy)
                Console.WriteLine($"Мне плевать, я медведь, паркуюсь(захожу) где хочу");
            else
                Console.WriteLine("Я хороший медведь, я не влезу, удачи Вам.");
        }

        public bool Choise { set { _goodOrBadBoy = value; } }


    }
}
