using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5_2
{
    class Ranger: Chess
    {
        public Ranger()
        {
            Skill();
        }
        public override void Skill()
        {
            character = "遊俠";
            hp = 90;
            mp = 10;
            atk = 30;
            atkRange = 3;
            moveRange = 1;
        }
        public override string toStr()
        {
            return $"{character}";
        }
    }
}
