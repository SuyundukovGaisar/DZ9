using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9
{
    internal class BeachGame : Game
    {
        public override void Play()
        {
            Console.WriteLine("Welcome to the Beach Game!");

            Rules();

            Console.WriteLine("Beach Game has ended!");
        }
        protected virtual void Rules()
        {

        }
    }
}
