using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5_2
{
    class Warrior: Chess
    {
        public Warrior()
        {
            Skill();
        }
        public override void Skill()
        {
            character = "戰士";
            hp = 100;
            mp = 15;
            atk = 30;
            atkRange = 1;
            moveRange = 2;
        }
        public override string toStr()
        {
            return $"{character}";
        }
    }
}
