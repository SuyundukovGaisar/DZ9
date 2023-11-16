using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team Russia = new Team("Россия", 15);
            Team France = new Team("Франция", 15);
            Team China = new Team("Китай", 15);
            Team Kazakhstan = new Team("Казахстан", 15);

            Game beach = new BeachGame();
            Game mouseTrap = new MouseTrapGame();
            Game sea = new SeaGame();
            Game fishing = new FishingGame();
            Game postmen = new PostmenGame();
            Game slide = new SlideGame();

            

        }
    }
}
