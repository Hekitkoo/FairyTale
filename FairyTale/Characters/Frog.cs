namespace FairyTale
{
    /// <summary>
    ///  Just a frog(not main character)
    /// </summary>
    class Frog : StoryObject
    {
        public Frog()
        {
            Name = "Лягушка попрыгушка";
            Size = 20;
            HowMove = "прыг-прыг";
        }
        public override string Name { get; set; }
        public override int Size { get; set; }
        public override string HowMove { get; set; }
    }
}
