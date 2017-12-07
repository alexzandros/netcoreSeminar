
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace aplicacionEjemplo1{

    public class DALMySQLContext: DbContext{
        public DbSet<Pelicula> pelicula {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder opciones){
            opciones.UseMySql("server=localhost;userid=root;pwd=12345678;port=3306;database=efcoretest;");
        }

    }

}