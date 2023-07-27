using FrancisLibrary.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FrancisLibrary.Core.Services
{
    public static class ItemService
    {
        public static List<Item> items;
        public static List<Item> rentedItems;
        
        
        static ItemService()
        {
            items = new List<Item>();
            rentedItems = new List<Item>();

            List<Item> newItems = new List<Item> {
                new Book("harryPotter1",1,Genre.Fantasy,"J. K. Rowling","J. K. Rowling", true),
                new Book("harryPotter2",1,Genre.Fantasy,"J. K. Rowling","J. K. Rowling", true),
                new Journal ("Journal",2,Genre.Action,"Journal",true)
            };
            items.AddRange(newItems);     
            
            List<Item> RentedItems= new List<Item>{
                new Book("harryPotter3",1,Genre.Fantasy,"J. K. Rowling","J. K. Rowling", true),
                new Book("harryPotter4",1,Genre.Fantasy,"J. K. Rowling","J. K. Rowling", true),
                new Journal ("bb",2,Genre.Action,"bb",true)
            };
            rentedItems.AddRange(RentedItems);
        }
        public static Item AddItem(string title, int catalogID, Genre enterGenre, ItemType itemType, string author = null, string publisher = null, string company = null, bool isAvailable = true)
        {
            ValidateItemParameters(title);

            Item newItem;
            switch (itemType)
            {
                case ItemType.Book:
                    newItem = new Book(title, catalogID, enterGenre, author, publisher, isAvailable);
                    break;
                case ItemType.Journal:
                    newItem = new Journal(title, catalogID, enterGenre, company, isAvailable);
                    break;
                default:
                    throw new ArgumentException("NO RIGHT ITEM TYPE");
            }

            items.Add(newItem);            
            return newItem;
        }
        //public static Item EditItem(string title, int catalogID, Genre enterGenre, ItemType Type, string author = null, string publisher = null, string company = null)
        //{
        //    foreach (Item item in items)
        //    {
        //        if(item.Title != title) { throw new ArgumentException("Title is incorrect! please try again"); }
        //        else if(item.CatalogID != catalogID) { throw new ArgumentException("Title is incorrect! please try again"); }
        //        else if(item.Genre != enterGenre) { throw new ArgumentException("Title is incorrect! please try again"); }
        //        else if(item.Type != Type) { throw new ArgumentException("Title is incorrect! please try again"); }
        //    }
        //} TODO
        public static void RemoveItem(string title)
        {
            foreach (Item item in items)
            {
                if (item.Title == title)
                {
                    items.Remove(item);
                    return;
                }
            }
            throw new ArgumentException("item can not be found please try again!");

        }
        public static void RentItem(string title)
        {
            foreach (Item item in items)
            {
                if (item.Title == title)
                {
                    items.Remove(item);
                    rentedItems.Add(item);
                    return;
                }
            }
            throw new ArgumentException("item can not be found please try again!");
        }
        public static void ReturnItem( string title)
        {
            foreach (Item item in rentedItems)
            {
                if (item.Title == title)
                {
                    rentedItems.Remove(item);
                    items.Add(item);
                    return;
                }
            }
            throw new ArgumentException("item can not be found please try again!");
        }

        private static void ValidateItemParameters(string title)
        {
            foreach (Item item in items)
            {
                if (item.Title == title) { throw new ArgumentException("Title already taken! please try again"); }

            }
        }
        

    }
}
