﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;

namespace Shop.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
       
    }
}
