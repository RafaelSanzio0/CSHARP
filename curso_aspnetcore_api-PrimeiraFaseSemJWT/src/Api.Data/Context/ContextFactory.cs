using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context {
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext> {
        public MyContext CreateDbContext (string[] args) {
            //Usado para Criar as Migrações (banco de dados,tabela)
            var connectionStringMySqlL = "server=localhost;database=UdemyDB;user=root;password=root";
            var connectionStringSqlServer = "Server=.\\SQLEXPRESS2017;Initial Catalog=UdemyDB;User ID=sa;Password=root;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(connectionStringMySqlL);
            optionsBuilder.UseSqlServer(connectionStringSqlServer);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
