using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainer
    {

        private Pokemon[] pokemonSum;

        public Pokemon[] PokemonSum
        {
            get { return pokemonSum; }
            set { pokemonSum = value; }
        }
    }
}
