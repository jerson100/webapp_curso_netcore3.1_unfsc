using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTDSII_2020.Data.AccesoDatos;

namespace WebAppTDSII_2020.Controllers
{
    public class BancosCabController : Controller
    {
        public IActionResult Index()
        {
            var LBancos = new DABancosCab();
            var modelo = LBancos.GetBancosCab();
            return View(modelo);
        }
    }
}
