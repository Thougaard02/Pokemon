using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class GUI
    {

        public void PokemonAreana(Pokemon pikachu, Pokemon magikrap)
        {
            
            GameController GC = new GameController();


            //Pikachu = x
            //Magikrap = y
            while (pikachu.Hp >= magikrap.Hp || magikrap.Hp >= pikachu.Hp)
            {
                if (pikachu.Hp <= 0)
                {
                    Console.WriteLine(pikachu.Pokename + " fainted");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if(pikachu.Hp >= 0)
                {
                    Console.WriteLine("Pikachu Used Attack " + pikachu.Attack);
                    magikrap.Hp -= pikachu.Attack;
                    GC.HealthCheck(pikachu, magikrap);
                    Console.WriteLine("Magikarp HP " + magikrap.Hp + "\n");
                    Console.ReadKey();

                }

                if (magikrap.Hp <= 0)
                {
                    Console.WriteLine(magikrap.Pokename + " fainted");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (magikrap.Hp >= 0)
                {
                    Console.WriteLine("Magikarp Used Attack " + magikrap.Attack);
                    pikachu.Hp -= magikrap.Attack;
                    GC.HealthCheck(pikachu, magikrap);
                    Console.WriteLine("Pikachu HP " + pikachu.Hp + "\n");
                    Console.ReadKey();
                }

            }            
        }
    
    }
}
