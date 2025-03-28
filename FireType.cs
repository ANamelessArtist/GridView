using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class FireType : Pokemon
    {
        public FireType() { }
        public FireType(string name, string nature, string move, string weakness, string ability)
            : base(name, nature)
        {
            Move = move;
            Weakness = weakness;
            Ability = ability;
        }

        public string Move {  get; set; }
        public string Weakness { get; set; }
        public string Ability { get; set; }
    }
}
