using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //after nimo og buhat og Entities para sa Database diria buhati og code para pag mag migrate
        // na makita na imohang database
        public DbSet<AppUser> Users {get; set;}
    }
}