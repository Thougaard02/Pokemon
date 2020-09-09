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

        private int maxhp;
       
        public int MaxHp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int currentHp;

        public int CurrentHp
        {
            get { return currentHp; }
            set { currentHp = value; }
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

        private int catchRate;

        public int Catchrate
        {
            get { return catchRate; }
            set { catchRate = value; }
        }
        
        public Pokemon(string pokename, string type, int maxHp, int currentHp, int attack, int defence, int speed, int catchRate)
        {
            Pokename = pokename;
            Type = type;
            MaxHp = maxHp;
            CurrentHp = currentHp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
            IsFainted = isFainted;
            Catchrate = catchRate;
        }
    }
}
