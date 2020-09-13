using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTDSII_2020.Models
{
    public class BancosDet
    {
        [Key]
        [Display(Name ="ID")]
        public int IdBancosDet { get; set; }

        [Display(Name = "PROVEEDOR")]
        [Required(ErrorMessage = "Debe de ingresar el Proveedor")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener más de 100 caracteres")]
        public string Proveedor { get; set; }

        [Display(Name = "RUC")]
        [Required(ErrorMessage = "Debe ingresar el RUC del Proveedor")]
        public int RUC { get; set; }

        [Display(Name = "DETALLE")]
        [Required(ErrorMessage = "Debe de ingresar el Detalle")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener más de 100 caracteres")]
        public string Detalle { get; set; }

        [Display(Name = "MONTO")]
        [Required(ErrorMessage = "Debe ingresar el Monto del Proveedor")]
        public float Monto { get; set; }

        [Display(Name = "FECHA REGISTRO")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "FECHA MODIFICACIÓN")]
        [DataType(DataType.Date)]
        public DateTime? FechaModificacion { get; set; }

        public int DiferenciaDias { get; set; }

        public int IdBancosCab { get; set; }
        [ForeignKey("IdBancosCab")]
        public virtual BancosCab BancosCab { get; set; }

    }
}
