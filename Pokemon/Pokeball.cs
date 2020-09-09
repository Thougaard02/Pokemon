using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    enum BallType
    {
        PokéBall,
        GreatBall,
        UltraBall,
        MasterBall
    }
    class Pokeball
    {
        private BallType type;
        public BallType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string pokeballName;

        public string PokeballName
        {
            get { return pokeballName; }
            set { pokeballName = value; }
        }

        private double catchRate;

        public double CatchRate
        {
            get { return catchRate; }
            set { catchRate = value; }
        }

        public Pokeball()
        {
            Type = type;
            PokeballName = pokeballName;
            CatchRate = catchRate;
        }

        public void PokeballCatchRate(BallType pokeball)
        {

            switch (pokeball)
            {
                case BallType.PokéBall:
                    catchRate = 1;
                    Type = BallType.PokéBall;
                    break;
                case BallType.GreatBall:
                    catchRate = 1.5;
                    Type = BallType.GreatBall;
                    break;
                case BallType.UltraBall:
                    catchRate = 2;
                    Type = BallType.UltraBall;
                    break;
                case BallType.MasterBall:
                    catchRate = 255;
                    Type = BallType.MasterBall;
                    break;
            }
        }
        public string CatchPokemon(Pokemon pokemon)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int n = 0;
            int ball = 12;

            switch (Type)
            {
                case BallType.PokéBall:
                    n = r.Next(0, 255);
                    break;
                case BallType.GreatBall:
                    n = r.Next(0, 200);
                    ball = 8;
                    break;
                case BallType.UltraBall:
                    n = r.Next(0, 150);
                    break;
                case BallType.MasterBall:
                    n = 0;
                    ball = 1;
                    break;
            }

            int f = 1;
            int m = 0;
            if (n < pokemon.Catchrate)
            {
                m = new Random(Guid.NewGuid().GetHashCode()).Next(0, 255);

                f = (pokemon.MaxHp * 255 * 4) / (pokemon.CurrentHp * ball);

                if (f >= m)
                {                    
                    return pokemon.Pokename + " was caught!";
                }
                else
                {                    
                    return "The pokemon broke free!";
                }
            }
            else
            {                
                return "Pokemon is gone";
            }
        }


    }
}
