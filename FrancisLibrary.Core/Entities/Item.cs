using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core
{
    public abstract class Item
    {
        public string Title { get; set; }
        public int CatalogID { get; set; }
        public Guid ItemID { get; set; } = Guid.NewGuid();
        public Genre Genre { get; set; }
        public DateTime EnterDate { get; set; } = DateTime.Now;
        public DateTime ReleaseDate { get; set; }
        public abstract ItemType Type { get; }
       
        public bool IsAvailable { get; set; } = true;

        public Item(int catalogId, string title, Genre enterGenre, bool isAvailable )
        {
            CatalogID= catalogId;
            Title= title;
            Genre= enterGenre;
            IsAvailable= isAvailable;
            
        }





    }


}


