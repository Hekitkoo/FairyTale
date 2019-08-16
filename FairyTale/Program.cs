using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    /// <summary>
    /// Main /:
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Story Characters
            StoryManager _storyManager = new StoryManager();
            IMainStoryObject _oldMan = new OldMan();
            StoryObject _mouse = new Mouse();
            StoryObject _frog = new Frog();
            StoryObject _bunny = new Bunny();
            StoryObject _wolf = new Wolf();
            StoryObject _bear = new Bear();
            // Story
            try
            {
            _storyManager.DoAct0();
            _storyManager.DoAct1(_oldMan);
            _storyManager.DoRepitableAct(_mouse);
            _storyManager.DoRepitableAct(_frog);
            _storyManager.DoRepitableAct(_bunny);
            _storyManager.DoRepitableAct(_wolf);
            _storyManager.DoAct2(_bear);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }


        }
    }
}
