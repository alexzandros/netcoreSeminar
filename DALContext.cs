using System.Data;
using Microsoft.EntityFrameworkCore;

namespace aplicacionEjemplo1{

    public class DALContext: DbContext{
        public DbSet<Pelicula> pelicula {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder opciones){
            opciones.UseSqlite("Data Source=pelis.db");
        }

    }

}