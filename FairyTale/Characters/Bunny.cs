namespace FairyTale
{
    /// <summary>
    ///  it's a bunny(not main character)
    /// </summary>
    class Bunny : StoryObject
    {
        public Bunny()
        {
            Name = "Зайчик побегайчик";
            Size = 30;
            HowMove = "прыг-прыг";

        }
        public override string Name { get; set; }
        public override int Size { get; set; }
        public override string HowMove { get; set; }
    }
}
