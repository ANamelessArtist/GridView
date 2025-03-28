using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Pokemon
    {
        public Pokemon() { }
        public Pokemon(string name, string nature)
        {
            Name = name;
            Nature = nature;
        }

        public string Name {  get; set; }
        public string Nature { get; set; }
    }
}
