using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5_2
{
    class Chess
    {
        public string character = "";
        public int hp;
        public int mp;
        public int atk;
        public int atkRange;
        public int moveRange;
        public int row = -1;
        public int col = -1;
        public virtual void Skill()
        {   

        }
        public virtual string toStr()
        {
            return "";
        }
    }
}
