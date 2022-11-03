using System.ComponentModel.DataAnnotations;

namespace CabañasProyecto.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DNI { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido{ get; set; }
        [Required]
        public string Direccion{ get; set; }
        [Required]
        public string Telefono{ get; set; }
        [Required]
        public string Email{ get; set; }

    }
}
