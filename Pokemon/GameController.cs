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
            if(x.MaxHp <= 0)
            {
                x.MaxHp = 0;                
            }

            if(y.MaxHp <= 0)
            {
                y.MaxHp = 0;                
            }
        }
    }
}
