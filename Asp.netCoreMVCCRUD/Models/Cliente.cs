using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Cliente
    {
        [Key]
        public int  id_cliente { get; set; }
        [Column (TypeName = "nvarchar(250)")]
        [Required]
        public String nombre_cliente { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public String direccion { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public String telefono { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String tipo_cliente { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String pais { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String departamento { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String ciudad { get; set; }

    }
}
