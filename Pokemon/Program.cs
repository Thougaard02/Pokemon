using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon("Pikachu", "Electric", 35, 55, 40, 90);
            Pokemon magikarp = new Pokemon("Magikarp", "Water", 100, 10, 55, 80);
            GUI gui = new GUI();            
            gui.PokemonAreana(pikachu, magikarp);
        }
    }
}

