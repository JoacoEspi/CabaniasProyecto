using System.ComponentModel.DataAnnotations;

namespace CabañasProyecto.Models
{
    public class Ubicacion
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string Localidad { get; set; }
        [Required]
        public List<Cabania> cabanias { get; set; }
    }
}
