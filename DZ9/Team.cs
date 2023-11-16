using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9
{
    internal class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, int memberCount)
        {
            Name = name;
            Members = new List<string>(memberCount);
        }
    }
}
