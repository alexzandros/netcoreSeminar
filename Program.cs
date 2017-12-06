using System;
using System.IO;
using System.Linq;

namespace aplicacionEjemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            var archivo = File.ReadAllLines("datos.txt");
            var listaPeliculas = DAL.ObtenerColeccionPeliculas(archivo).
                OrderBy(x => x.ApellidoDirector).
                Select(x => string.Format("El director {0} dirige la película {1}", x.NombreDirector, x.NombrePelicula));
            foreach (var película in listaPeliculas){
                Console.WriteLine(película);
            }
             var loka = from peli in DAL.ObtenerColeccionPeliculas(archivo)
                orderby peli.NombrePelicula
                select peli;
                

            //Incluimos el contexto de persistencia
            var contexto = new DALContext(); 

            /******************************************************************
             *                                                                *
             *  A continuación se va a volver a leer el archivo de texto      *
             *  para insertar cada uno de los registros en la tabla de la     *
             *  base de datos de Sqlite.                                      *
             *                                                                *
             *****************************************************************/
                
            foreach (var registro in DAL.ObtenerColeccionPeliculas(archivo).
                Skip(1)){
                contexto.pelicula.Add(registro);
                Console.WriteLine("Inserté la película {0}",
                    registro.NombrePelicula);
            }
            contexto.SaveChanges();
        }
    }
}
