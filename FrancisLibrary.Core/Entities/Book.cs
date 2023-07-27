using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core.Entities
{
    public class Book : Item
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public override ItemType Type { get => ItemType.Book; }
        public Book(string title, int catalogId, Genre enterGenre, string author, string publisher, bool isAvailable) : base(catalogId, title, enterGenre,isAvailable )
        {
            Author= author;
            Publisher= publisher;
        }
    }
}
