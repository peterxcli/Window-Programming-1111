using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5_2
{
    class Mage: Chess
    {
        public Mage()
        {
            Skill();
        }
        
        public override void Skill()
        {
            character = "法師";
            hp = 70;
            mp = 25;
            atk = 20;
            atkRange = 2;
            moveRange = 2;
        }
        public override string toStr()
        {
            return $"{character}";
        }
    }
}
