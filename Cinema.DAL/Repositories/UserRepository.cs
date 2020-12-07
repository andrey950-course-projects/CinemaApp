﻿using Cinema.DAL.Commons;
using Cinema.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repositories
{
    public class UserRepository : GenericRepository<User, int>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
