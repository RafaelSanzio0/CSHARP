using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionStringSqlServer = "Server=.\\SQLEXPRESS2017;Initial Catalog=AluraDB;User ID=sa;Password=root;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder.UseSqlServer(connectionStringSqlServer);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
