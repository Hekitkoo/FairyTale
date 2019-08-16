using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
