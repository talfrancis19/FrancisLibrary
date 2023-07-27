using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core
{
     public enum Genre
    {
        Action,
        Drama,
        Fantasy,
        Adventure,
        Romance,
        Horror,
        Children
    }
    public enum ItemType
    {
        Book,
        Journal
    }
    public enum ItemStatus
    {
        Rented,
        Available,
        Removed
    }

    public class ComboData
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
