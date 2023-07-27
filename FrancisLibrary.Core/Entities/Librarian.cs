using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core.Entities
{
    public class Librarian : User
    {
        public Librarian(string username, string password) : base(username, password) 
        {

        }
    }
}
