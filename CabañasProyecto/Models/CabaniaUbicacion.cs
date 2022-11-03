using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CabañasProyecto.Models
{
    public class CabaniaUbicacion
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Cabania))]
        public int CabaniaId { get; set; }
        public Cabania Cabania { get; set; }
        [ForeignKey(nameof(Ubicacion))]
        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
