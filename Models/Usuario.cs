using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCVmma.Models
{
    public class Usuario
    {
        // ATRIBUTOS DEL USUARIO
        [Key]
        public int PkUser { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        // LLAVE FORANEA
        [ForeignKey("Rol")]
        public int? FkRol { get; set; }
        public Roles Rol { get; set; }
    }
}
