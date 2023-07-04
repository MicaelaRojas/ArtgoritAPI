using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiUsuarios2.Models
{
    [Table("galeria_virtual")]
    public class Galeria_virtual
    {
        [Key]
        public int id { get; set; }
        public string nombre_obra { get; set; }
        public string nombre_autor { get; set; }
        public byte[] imagen { get; set; }
        public string codigo_imagen { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}

