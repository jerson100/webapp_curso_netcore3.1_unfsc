using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppTDSII_2020.Data;
using WebAppTDSII_2020.Data.AccesoDatos;
using WebAppTDSII_2020.Models;

namespace WebAppTDSII_2020.Controllers
{
    public class BancosDetController : Controller
    {

        //public IActionResult LBancosDet()
        //{
        //    var LBBancosCab = new DABancosDet();
        //    var listado = LBBancosCab.GetBancosDet();
        //    ViewBag.BancosCab = new DABancosCab().GetBancosCab();
        //    ViewBag.list = listado;
        //    return View();
        //}

        [HttpGet]
        public IActionResult LBancosDet(BancosDetBinding BancosBinding)
        {

            var LBBancosCab = new DABancosDet();

            ViewData["BancosCab"] = new DABancosCab().GetBancosCab();

            if (BancosBinding.IdBancosCab == 0 || BancosBinding.IdMonth == 0)
            {
                ViewData["list"] = LBBancosCab.GetBancosDet();
            }
            else
            {
                ViewData["list"] = LBBancosCab.GetBancosDet(BancosBinding.IdBancosCab, BancosBinding.IdMonth);
            }

            return View();

        }

        public IActionResult Create()
        {
            var BancosCab = new DABancosCab();
            ViewBag.BancosCab = BancosCab.GetBancosCab();
            return View();
        }

        [HttpPost]
        public IActionResult Create(BancosDet BancosDetalle)
        {
            BancosDetalle.IdBancosDet = 0;
            BancosDetalle.FechaRegistro = DateTime.Now;
            var BancDet = new DABancosDet();
            var Resultado = BancDet.InsertBancosDet(BancosDetalle);
            if(Resultado > 0)
            {
                return RedirectToAction("LBancosDet");
            }
            else
            {
                return View(BancosDetalle);
            }
        }

        public IActionResult Edit(int id)
        {
            var UpdateBancosCab = new DABancosCab();
            ViewBag.BancosCab = UpdateBancosCab.GetBancosCab();

            var UpBancosDet = new DABancosDet();
            var modelo = UpBancosDet.GetIdBancosDet(id);
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Edit(BancosDet BancosDetalle)
        {
            DateTime fechaActual = DateTime.Now;
            BancosDetalle.FechaModificacion = fechaActual;
            int diferenciaDias = (int)fechaActual.Subtract(BancosDetalle.FechaRegistro).TotalDays;
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(fechaActual);
            //Console.WriteLine(BancosDetalle.FechaRegistro);
            Console.WriteLine("=====================");
            BancosDetalle.DiferenciaDias = diferenciaDias;
            /*
                Por si se necesita quitar los días domingos
                BancosDetalle.DiferenciaDias = DiffDays(BancosDetalle.FechaRegistro, fechaActual);
             */
            var editar = new DABancosDet();
            var Resultado = editar.UpdateBancosDet(BancosDetalle);
            if (Resultado)
            {
                return RedirectToAction("LBancosDet");
            }
            else
            {
                return View(BancosDetalle);
            }
        }

        private static int DiffDays(DateTime registro, DateTime actualizacion)
        {
            var fechaDeRegistro = registro;
            var fechaDeModificacion = actualizacion;
            var diffDays = fechaDeModificacion.Subtract(fechaDeRegistro).TotalDays;
            var countBusinessDays = diffDays;
            for (var i = 1; i <= diffDays; i++)
            {
                if (fechaDeRegistro.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {
                    countBusinessDays--;
                }
            }
            return (int)countBusinessDays;
        }

    }
}
