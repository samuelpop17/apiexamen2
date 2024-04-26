using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExamen2.Models
{
    [Table("USUARIOSCUBO")]
    public class UsuarioCubo
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }
        [Column("PASS")]
        public string Pass { get; set; }
    }
}
