using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    /// Interface for main character(s)
    /// </summary>
    interface IMainStoryObject
    {
        ICollection<StoryObject> Objects { get; set; }
        void DoPlotTwist();
    }
}
