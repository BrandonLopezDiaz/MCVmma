using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCVmma.Models
{
    public class Roles
    {
        [Key]
        public int PkRol { get; set; }
        public string Name { get; set; }
    }
}
// add-migration Example