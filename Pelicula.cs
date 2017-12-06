using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace aplicacionEjemplo1
{
    public class Pelicula{
        [StringLength(255)]
        [Required]
        public string NombreDirector { get; set; }
        [StringLength(255)]
        [Required]
        public string ApellidoDirector { get; set; }
        [StringLength(255)]
        [Key]
        public string NombrePelicula { get; set; }
    }
}