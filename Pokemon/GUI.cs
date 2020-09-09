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
            while (pikachu.MaxHp >= magikrap.MaxHp || magikrap.MaxHp >= pikachu.MaxHp)
            {
                if (pikachu.MaxHp <= 0)
                {
                    Console.WriteLine(pikachu.Pokename + " fainted");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (pikachu.CurrentHp >= 0)
                {
                    Console.WriteLine("Pikachu Used Attack " + pikachu.Attack);
                    magikrap.MaxHp -= pikachu.Attack;
                    GC.HealthCheck(pikachu, magikrap);
                    Console.WriteLine("Magikarp HP " + magikrap.MaxHp + "\n");
                    Console.ReadKey();

                }

                if (magikrap.MaxHp <= 0)
                {
                    Console.WriteLine(magikrap.Pokename + " fainted");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (magikrap.CurrentHp >= 0)
                {
                    Console.WriteLine("Magikarp Used Attack " + magikrap.Attack);
                    pikachu.MaxHp -= magikrap.Attack;
                    GC.HealthCheck(pikachu, magikrap);
                    Console.WriteLine("Pikachu HP " + pikachu.MaxHp + "\n");
                    Console.ReadKey();
                }

            }
        }
    }
}
