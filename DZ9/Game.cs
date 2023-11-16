using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9
{
    public abstract class Game
    {
        public string Name { get; set; }
        public virtual void Play()
        {
            
        }
    }
}
