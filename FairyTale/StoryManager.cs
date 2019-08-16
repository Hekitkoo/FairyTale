﻿using System;
using System.Linq;

namespace FairyTale
{
    /// <summary>
    /// Manager of storytelling
    /// </summary>
    class StoryManager
    {
        //
        static Random random = new Random();
        static string Name = "Рукавичка(ООП версия)";
        // prop
        Glove _mainVictim;
        // Name of the Story
        public void DoAct0()
        {
            Console.SetCursorPosition((Console.WindowWidth - Name.Length) / 2, Console.CursorTop);
            Console.WriteLine(Name);
        }
        // Old Man lost Glove
        public void DoAct1(IMainStoryObject oldMan)
        {
            if (oldMan.Objects.First() is Glove)
            {
                _mainVictim = oldMan.Objects.First() as Glove;
                oldMan.DoPlotTwist();
            }
        }
        // main plot(repitable)
        public void DoRepitableAct(StoryObject character)
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
        public void DoAct2(StoryObject character)
        {
            // random choise
            bool _bearChois = Convert.ToBoolean(random.Next(0, 2));
            Console.WriteLine($"Вот {character.HowMove} {character.Name}. Увидела оъект типа {_mainVictim.Name} и такая(ой):");
            // sync choise
            if (character is Bear)
            {
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
}
