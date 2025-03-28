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
            new FireType("Charizard", "Timid", "Fire wheel", "Water/Rock/Electric", "Blaze"),
            new FireType("Moltres", "Lonely", "Overheat", "Water/Rock/Electric", "Control fire"),
            new FireType("Victini", "Mild", "V-Flare", "Water/Dark/Ghost/Ground", "Victory star"),
            new FireType("Groudon", "Gentle", "Earthquake", "Water/Grass/Ice", "Blaze"),
            new FireType("Ho-Oh", "Docile", "Brave bird", "Water/Rock/Electric", "Solar Power")
        };
        public List<FireType> MostrarPokemon()
        {
            return fireTypes;
        }
    }
}
