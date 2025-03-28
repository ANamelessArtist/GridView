using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Acciones
    {
        List<FireType> fireTypes = new List<FireType> 
        { 
            new FireType("Charizard", "Timid", "Fire wheel", "Water/Rock/Electric", "Blaze")
        };
        public List<FireType> MostrarPokemon()
        {
            return fireTypes;
        }
    }
}
