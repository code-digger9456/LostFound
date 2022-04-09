using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Modals
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {

        }
       
        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<LostIItems> Lost { get; set; }
    }
}
