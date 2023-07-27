using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core.Entities
{
    public class Journal : Item
    {
        public override ItemType Type { get => ItemType.Journal; }

        public Journal(string title, int catalogId, Genre enterGenre, string company,bool isAvailable) : base(catalogId, title, enterGenre, isAvailable)
        {
            Company = company;
        }

        public string Company {  get; set; }
    }
}
