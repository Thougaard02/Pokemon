using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class GameController
    {
        public void HealthCheck(Pokemon x, Pokemon y)
        {
            if(x.Hp <= 0)
            {
                x.Hp = 0;                
            }

            if(y.Hp <= 0)
            {
                y.Hp = 0;                
            }
        }
    }
}
