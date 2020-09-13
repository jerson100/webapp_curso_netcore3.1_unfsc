using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTDSII_2020.Models;

namespace WebAppTDSII_2020.Data.AccesoDatos
{
    public class DABancosCab
    {
        public IEnumerable<BancosCab> GetBancosCab()
        {
            var listado = new List<BancosCab>();
            using(var db = new ApplicationDbContext())
            {
                listado = db.BancosCab.ToList();
            }
            return listado;
        }
    }
}
