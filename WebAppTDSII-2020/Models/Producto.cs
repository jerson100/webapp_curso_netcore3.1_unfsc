using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTDSII_2020.Models
{
    public class Producto
    {
        [Key]
        [Display(Name ="IDPRODUCTO")]
        public int IdProducto { get; set; }

        [Display(Name = "NOMBRE")]
        public string Nombre { get; set; }

        [Display(Name = "CODIGO")]
        public string Codigo { get; set; }

        [Display(Name = "UNIDAD MEDIDA")]
        public string UnidadMedida { get; set; }

        [Display(Name = "FECHA")]
        public float Precio { get; set; }

        [Display(Name = "STOCK")]
        public float Stock { get; set; }

        [Display(Name = "FECHA REGISTRO")]
        public DateTime FechaRegistro { get; set; }
        
    }
}
