using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    ///  Just a wolf(not main character)
    /// </summary>
    class Wolf : StoryObject, IMainStoryObject
    {
        public override string Name => "Волчок серый бочок";
        public override int Size => 60;

        public ICollection<StoryObject> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void DoPlotTwist()
        {
            throw new System.NotImplementedException();
        }
    }
}
