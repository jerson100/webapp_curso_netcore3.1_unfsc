using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTDSII_2020.Models
{
    public class BancosCab
    {
        [Key]
        [Display(Name ="IDBANCOSCAB")]
        public int IdBancosCab { get; set; }

        [Display(Name = "BANCOS")]
        [Required(ErrorMessage = "Debe ingresar el nombre del Banco")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener más de 100 caracteres")]
        public string Nombre { get; set; }

        public virtual ICollection<BancosDet> BancosDet { get; set; }
    }
}
