using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConcesionarioMVC.Models
{
    public partial class Vehiculos
    {
        [Required]
        [DisplayName("Matricula:")]
        [DataType(DataType.MultilineText)]
        public string matricula { get; set; }
        [Required]
        [DisplayName("Marca:")]
        [DataType(DataType.MultilineText)]
        public string marca { get; set; }
        [Required]
        [DisplayName("Modelo:")]
        [DataType(DataType.MultilineText)]
        public string modelo { get; set; }

        [DisplayName("Coste:")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> coste { get; set; }
        [DisplayName("Tipo:")]
        [DataType(DataType.MultilineText)]
        public Nullable<int> idTipo { get; set; }
    }
}