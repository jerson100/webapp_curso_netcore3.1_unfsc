using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTDSII_2020.Models
{
    public class BancosDetBinding
    {
        public int IdBancosCab { get; set; }
        public int IdMonth { get; set; }
        public BancosDet bancosDet {get; set;}
    }
}
