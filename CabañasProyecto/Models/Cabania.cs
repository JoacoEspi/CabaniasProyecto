using System.ComponentModel.DataAnnotations;

namespace CabañasProyecto.Models
{
    public class Cabania
    {
        [Key]
        public int Id{ get; set; }
        [Required]  
        public double Precio { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        public bool Estado { get; set; }

    }
}
