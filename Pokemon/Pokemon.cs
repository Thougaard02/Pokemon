using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        
        private string pokename;

        public string Pokename
        {
            get { return pokename; }
            set { pokename = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int hp;
       
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int attack;

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        private int defence;

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private bool isFainted;

        public bool IsFainted
        {
            get { return isFainted; }
            set { isFainted = value; }
        }
        

        public Pokemon(string pokename, string type, int hp, int attack, int defence, int speed)
        {
            Pokename = pokename;
            Type = type;
            Hp = hp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
            IsFainted = isFainted;           
        }


        void TakeDamage(int attack)
        {
            if(attack >= hp)
            {
                isFainted = true;
            }
        }

    }
}
