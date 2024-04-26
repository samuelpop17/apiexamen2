using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExamen2.Models
{
    [Table("CUBOS")]
    public class Cubo
    {
        [Key]
        [Column("id_cubo")]
        public int IdCubo{ get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("marca")]
        public string Marca { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }
        [Column("precio")]
        public int Precio { get; set; }
        
    }
}
