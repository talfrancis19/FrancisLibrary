using FrancisLibrary.Core.Entities;
using FrancisLibrary.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace FrancisLibrary.Core.Services
{
    public static class UserService
    {
        public static List<User> users;      
         static UserService()
        {
            users = new List<User>();
            Librarian admin = new Librarian("admin", "123");
            Member testMember = new Member("member", "123");
            users.Add(admin);
            users.Add(testMember);
        }
        public static User Login(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    UserLogonActions.loggedInUser = user;                   
                    return user;
                }
            }
            return null;
        }
        public static Member AddMemberFunc(string username, string password) 
        {
            foreach (User user in users) 
            {
                if (user.Username == username) { throw new ArgumentException("Username already taken please try again. "); }
            }           
            Member newMember= new Member(username, password);
            users.Add(newMember);             
            return newMember;           
        }       
        public static User RemoveMemberFunc(string username) 
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                users.Remove(user);
                return user;
                } 
            }
            throw new ArgumentException("Username already taken please try again.");


        }
    }
}
