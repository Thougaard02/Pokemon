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
            Pokemon pikachu = new Pokemon("Pikachu", "Electric", 35, 10, 55, 40, 90, 190);
            Pokemon magikarp = new Pokemon("Magikarp", "Water", 100, 10, 10, 55, 80, 255);


            while (true)
            {

                Pokeball pokeball = new Pokeball();
                pokeball.PokeballCatchRate(BallType.MasterBall);
                Console.WriteLine(pokeball.CatchPokemon(pikachu));
                Console.ReadKey();


                GUI gui = new GUI();
                gui.PokemonAreana(pikachu, magikarp);
            }



            //gui.PokemonMenu();

        }
    }
}

