namespace FairyTale
{
    /// <summary>
    /// Character (not main)
    /// </summary>
    class Mouse : StoryObject
    {
        public Mouse()
        {
            Name = "Мышка поскребушка";
            Size = 10;
        }
        public override string Name { get; set; }
        public override int Size { get; set; }


    }
}
