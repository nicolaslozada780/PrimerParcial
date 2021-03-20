using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace Parcial1Lozada.Models
{
    public class ProductoID
    {
        [Key]
        public int ProductoId { get; set; }
        [StringLength(99999, MinimumLength = 1, ErrorMessage = "Indique un producto entre 1 y 99999 caracteres")]
        public string Description { get; set; }
        [StringLength(30,MinimumLength =30,ErrorMessage ="Indique una descripcion entre 3 y 30 caracteres")]
        [Required]
        public DataType Price { get; set; }
        public DataType LastBuy { get; set; }
    }
}