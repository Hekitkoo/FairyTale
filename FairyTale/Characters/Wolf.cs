namespace FairyTale
{
    /// <summary>
    ///  Just a wolf(not main character)
    /// </summary>
    class Wolf : StoryObject
    {
        public Wolf()
        {
            Name = "Волчок серый бочок";
            Size = 60;
        }
        public override string Name { get; set; }
        public override int Size { get; set; }
    }
}
