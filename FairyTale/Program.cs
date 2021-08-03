using System;
using System.Collections.Generic;
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
            var bear = new Bear();

            ICollection<StoryObject> animals = new List<StoryObject>()
            {
                new Mouse(), new Frog(), new Bunny(), new Wolf()
            };
            // Story
            action = storyManager.DoRepitableAct;
            try
            {
                storyManager.DoActionZero();
                storyManager.DoActionOne(oldMan);
                foreach (StoryObject animal in animals)
                {
                    action(animal);
                }
                storyManager.FinalAction(bear);
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
