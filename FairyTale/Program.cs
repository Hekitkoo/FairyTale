using System;
using System.Text;

namespace FairyTale
{
    /// <summary>
    /// Main /:
    /// </summary>
    class Program
    {
        // delegate 
        delegate void Action(StoryObject storyMan);
        static void Main(string[] args)
        {
            Action action;
           
            // change encoding console(for people who have english version Windows)
            Console.OutputEncoding = Encoding.UTF8;
            // Story Characters
            var storyManager = new StoryManager();
            var oldMan = new OldMan();
            var mouse = new Mouse();
            var frog = new Frog();
            var bunny = new Bunny();
            var wolf = new Wolf();
            var bear = new Bear();
            // Story
            action = storyManager.DoRepitableAct;
            try
            {
                storyManager.DoAct0();
                storyManager.DoAct1(oldMan);
                action(mouse);
                action(frog);
                action(bunny);
                action(wolf);
                //storyManager.DoRepitableAct(mouse);
                //storyManager.DoRepitableAct(frog);
                //storyManager.DoRepitableAct(bunny);
                //storyManager.DoRepitableAct(wolf);
                storyManager.DoAct2(bear);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
