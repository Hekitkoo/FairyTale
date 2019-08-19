using System.Collections.Generic;

namespace FairyTale
{
    /// <summary>
    ///  Just a frog(not main character)
    /// </summary>
    class Frog : StoryObject, IMainStoryObject
    {
        public override string Name => "Лягушка попрыгушка";
        public override int Size => 20;
        public override MoveStyle HowMove => MoveStyle.Jump;
        public ICollection<StoryObject> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void DoPlotTwist()
        {
            throw new System.NotImplementedException();
        }
    }
}
