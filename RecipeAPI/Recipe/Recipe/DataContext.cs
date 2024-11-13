using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Recipe
{
    public class DataContext : IDataContext
    {
        public List<User> Users { get; set; }
        public DataContext()
        {
            Users = new List<User> { new User
            { Id = 1, UserName = "mimi", Password = "mi123mi", Email = "mimi@gmail.com"}
            , new User{ Id = 2, UserName = "yael", Password = "ya1el", Email = "yael@gmail.com"}
            };
        }
             
        }
   

 }

