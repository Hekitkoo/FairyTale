namespace FairyTale
{
    /// <summary>
    ///  Just a frog(not main character)
    /// </summary>
    class Frog : StoryObject
    {
        public Frog()
        {
            HowMove = "прыг-прыг";
        }
        public override string Name => "Лягушка попрыгушка";
        public override int Size => 20;
        public override string HowMove { get; set; }
    }
}
