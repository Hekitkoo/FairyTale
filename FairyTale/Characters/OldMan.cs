using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Objects = new List<AbstractStoryObject>
            {
                new Glove()
            };
        }
        // prop
        public ICollection<AbstractStoryObject> Objects { get; set; }
        
        // Lost glove
        public void DoPlotTwist()
        {
            Objects.First().Action(this);
            Objects.Clear();
        }
    }
}
