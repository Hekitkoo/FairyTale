namespace FairyTale
{
    /// <summary>
    ///  it's a bunny(not main character)
    /// </summary>
    class Bunny : StoryObject
    {
        public Bunny()
        {
            HowMove = "прыг-прыг";
        }
        public override string Name => "Зайчик побегайчик";
        public override int Size => 30;
        public override string HowMove { get; set; }
    }
}
