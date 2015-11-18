using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioMVC.Models
{
    public partial class Tipos
    {
        public int idTipo { get; set; }

        [Required]
        [DisplayName("Nombre:")]
        [DataType(DataType.MultilineText)]
        public string nombre { get; set; }

        [DisplayName("Descripción:")]
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; }
    }
}
