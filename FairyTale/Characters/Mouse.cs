using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    /// Character (not main)
    /// </summary>
    class Mouse : StoryObject, IMainStoryObject
    {
        public override string Name => "Мышка поскребушка";
        public override int Size => 10;

        public ICollection<StoryObject> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void DoPlotTwist()
        {
            throw new System.NotImplementedException();
        }
    }
}
