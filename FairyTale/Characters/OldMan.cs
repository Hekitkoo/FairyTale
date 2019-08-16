﻿using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    ///  One of the main characters this story/
    /// </summary>
    class OldMan : IMainStoryObject
    {
        // ctor
        public OldMan()
        {
            Objects = new List<StoryObject>
            {
                new Glove()
            };
        }
        // prop
        public ICollection<StoryObject> Objects { get; set; }
        
        // Lost glove
        public void DoPlotTwist()
        {
            Objects.Clear();
        }
    }
}
