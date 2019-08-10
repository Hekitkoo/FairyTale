﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    /// <summary>
    /// Manager of storytelling
    /// </summary>
    class StoryManager
    {
        static Random random = new Random();
        // prop
        Glove _mainVictim;
        static string Name = "Рукавичка(ООП версия)";

        // Name of the Story
        public void DoAct0()
        {
            Console.SetCursorPosition((Console.WindowWidth - Name.Length) / 2, Console.CursorTop);
            Console.WriteLine(Name);
            Console.WriteLine("Шёл дед лесом. Шёл дед, шёл, да и обронил рукавичку.");

        }
        // Old Man lost Glove
        public void DoAct1(IMainStoryObject oldMan)
        {
            if (oldMan.Objects.First() is Glove)
            _mainVictim = oldMan.Objects.First() as Glove;
            oldMan.DoPlotTwist();
        }
        // main plot(repitable)
        public void DoRepitableAct(AbstractStoryObject character)
        {
            Console.WriteLine($"Вот {character.HowMove} {character.Name}. Увидела оъект типа {_mainVictim.Name} и такая(ой):");
            character.Action(_mainVictim);
            if (_mainVictim.Objects.Count != 0)
            {

                // Get all characters who live in gloves
                var _nameList = string.Join(", ", _mainVictim.Objects.Select(obj => obj.Name));

                Console.WriteLine($"{_nameList}. Заходи {character.Name}.");
            }            
            _mainVictim.Objects.Add(character);
            Console.WriteLine($"Вот их уже {_mainVictim.Objects.Count}.");
        }
        // Bear come to gloves
        public void DoAct2(AbstractStoryObject character)
        {
            // random choise
            bool _bearChois = Convert.ToBoolean(random.Next(0, 2));
            Console.WriteLine($"Вот {character.HowMove} {character.Name}. Увидела оъект типа {_mainVictim.Name} и такая(ой):");

            // sync choise
            if (character is Bear)
            (character as Bear).Choise = _bearChois;

            if (_bearChois)
            {
                character.Action(_mainVictim);
                _mainVictim.Objects.Add(character);
            }
            else
            {
                character.Action(_mainVictim);
            }

            _mainVictim.DoPlotTwist();

        }
    }
}
