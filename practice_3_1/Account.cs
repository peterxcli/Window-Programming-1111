using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3_1
{
    public class Account
    {
        public string link, user, password;
        public Account(string link, string user, string password)
        {
            this.link = link;
            this.user = user;
            this.password = password;
        }
    }
}
