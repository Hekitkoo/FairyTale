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
            // change encoding console(for people who have english version Windows)
            Console.OutputEncoding = Encoding.UTF8;
            // Story Characters
            var _storyManager = new StoryManager();
            var _oldMan = new OldMan();
            var _mouse = new Mouse();
            var _frog = new Frog();
            var _bunny = new Bunny();
            var _wolf = new Wolf();
            var _bear = new Bear();
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
