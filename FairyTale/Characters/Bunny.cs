﻿using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    ///  it's a bunny(not main character)
    /// </summary>
    class Bunny : StoryObject, IMainStoryObject
    {
        public Bunny()
        {
            HowMove = "прыг-прыг";
        }
        public override string Name => "Зайчик побегайчик";
        public override int Size => 30;
        public override string HowMove { get; set; }
        public ICollection<StoryObject> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void DoPlotTwist()
        {
            throw new System.NotImplementedException();
        }
    }
}
