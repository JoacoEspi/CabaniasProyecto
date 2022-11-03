using System.ComponentModel.DataAnnotations;

namespace CabañasProyecto.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public DateTime? FechaInicio { get; set; }
        [Required]  
        public DateTime? FechaFin { get; set; }
        [Required]
        public Cabania Cabania { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
    }
}
