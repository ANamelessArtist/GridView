using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Acciones
    {
        FireType a = new FireType();
        
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
        public bool EliminarPokemon(string name)
        {
            try
            {
                var eliminar = fireTypes.Find(x => x.Name == name);
                if (eliminar != null)
                {
                    fireTypes.Remove(eliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AgregarPokemon(string name, string nature, string move, string weakness, string ability)
        {
            try
            {
                fireTypes.Add(new FireType(a.Name = name, a.Nature = nature, a.Move = move, a.Weakness = weakness, a.Ability = ability));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
