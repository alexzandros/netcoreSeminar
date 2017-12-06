using System.Collections.Generic;

namespace aplicacionEjemplo1{
    public static class DAL{
        
        public static Pelicula ConvertirRegistroAPelícula(string registro){
            if (string.IsNullOrEmpty(registro)){
                return null;
            }
            string[] cadenaSeparada = registro.Split(",");
            Pelicula peliculaObj = new Pelicula();
            peliculaObj.NombreDirector = cadenaSeparada[0];
            peliculaObj.ApellidoDirector = cadenaSeparada[1];
            peliculaObj.NombrePelicula = cadenaSeparada[2];
            return peliculaObj;
        }

        public static ICollection<Pelicula> ObtenerColeccionPeliculas(string[] registros){
            if (registros == null){
                return null;            
            }
            ICollection<Pelicula> coleccionPeliculas = new List<Pelicula>();
            foreach (var registro in registros){
                coleccionPeliculas.Add(ConvertirRegistroAPelícula(registro));
            }
            return coleccionPeliculas;
        }
    }
}