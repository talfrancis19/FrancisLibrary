using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core.Entities
{
    public class Member : User
    {
        public int DaysAllowdPerRent = 14;
        public Member(string username, string password) : base(username, password)
        {

        }
    }
}
