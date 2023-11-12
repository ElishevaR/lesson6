using Microsoft.EntityFrameworkCore;
using People.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Model
{
    public  class PeopleContext: DbContext
    {

        public PeopleContext(DbContextOptions<PeopleContext> options)
            : base(options)
        {

        }
        
        public DbSet<People> peoples { get; set; }
    }
}
