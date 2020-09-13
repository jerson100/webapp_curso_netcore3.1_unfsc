using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTDSII_2020.Models;

namespace WebAppTDSII_2020.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var PropiedadProducto = new Producto();
            PropiedadProducto.IdProducto = 1;
            PropiedadProducto.Nombre = "Fierro corrugada 1/2";
            PropiedadProducto.Codigo = "FE001";
            PropiedadProducto.UnidadMedida = "UND";
            PropiedadProducto.Precio = 25;
            PropiedadProducto.Stock = 5;
            PropiedadProducto.FechaRegistro = DateTime.Now;
            return View(PropiedadProducto);
        }

        private List<Producto> GetProducto()
        {
            var resultado = new List<Producto>();
            resultado.Add(new Producto
            {
                IdProducto = 1,
                Nombre = "Arandela",
                Codigo = "FE001",
                UnidadMedida = "Kilo",
                Precio = 2,
                Stock = 300,
                FechaRegistro = DateTime.Now
            });

            resultado.Add(new Producto
            {
                IdProducto = 2,
                Nombre = "Aceite Primor",
                Codigo = "AC001",
                UnidadMedida = "Litro",
                Precio = 7,
                Stock = 50,
                FechaRegistro = DateTime.Now
            });;

            resultado.Add(new Producto
            {
                IdProducto = 3,
                Nombre = "Perno F.N 1/2",
                Codigo = "FE002",
                UnidadMedida = "UND",
                Precio = 7,
                Stock = 5,
                FechaRegistro = DateTime.Now
            }); ;

            resultado.Add(new Producto
            {
                IdProducto = 4,
                Nombre = "Cemento Sol",
                Codigo = "FE003",
                UnidadMedida = "KG",
                Precio = 50,
                Stock = 25,
                FechaRegistro = DateTime.Now
            }); ;

            resultado.Add(new Producto
            {
                IdProducto = 5,
                Nombre = "Visagra 1/2",
                Codigo = "FE004",
                UnidadMedida = "UND",
                Precio = 15,
                Stock = 26,
                FechaRegistro = DateTime.Now
            }); ;

            return resultado;
        } 

        public IActionResult Listado()
        {
            var ListadoProducto = GetProducto();
            ViewBag.LProducto = ListadoProducto;
            return View();
        }

        public IActionResult ListadoModel()
        {
            var ListadoModel = GetProducto();
            return View(ListadoModel);
        }

        public IActionResult IndexViewDate()
        {
            //ViewData transfiere datos del controlador a la vista
            ViewData["Titulo"] = "Listado de Productos - ASP.NET CORE MVC";
            ViewData["EPP"] = "IdProducto";
            ViewData["ESP0"] = "Nombre";
            ViewData["ETP"] = "Codigo";
            ViewData["ECP"] = "Unidad Medida";
            ViewData["EQP"] = "Precio";
            ViewData["ESP"] = "Stock";
            ViewData["ESP1"] = "Fecha Creación";
            IList<Producto> ProductoList = new List<Producto>();
            ProductoList.Add(new Producto()
            {
                IdProducto = 1,
                Nombre = "Aceite Shell Rimula",
                Codigo = "AC001",
                UnidadMedida = "GLN",
                Precio = 35,
                Stock = 34,
                FechaRegistro = DateTime.Now
            }) ;

            ProductoList.Add(new Producto()
            {
                IdProducto = 2,
                Nombre = "Fierro ",
                Codigo = "FE001",
                UnidadMedida = "UND",
                Precio = 29,
                Stock = 25,
                FechaRegistro = DateTime.Now
            });
            ViewData["LProducto"] = ProductoList;
            return View();


        }

        public IActionResult IndexTemData()
        {
           
            IList<Producto> ProductoListTD = new List<Producto>();
            ProductoListTD.Add(new Producto()
            {
                IdProducto = 1,
                Nombre = "Aceite Shell Rimula",
                Codigo = "AC001",
                UnidadMedida = "GLN",
                Precio = 35,
                Stock = 34,
                FechaRegistro = DateTime.Now
            });

            ProductoListTD.Add(new Producto()
            {
                IdProducto = 2,
                Nombre = "Fierro ",
                Codigo = "FE001",
                UnidadMedida = "UND",
                Precio = 29,
                Stock = 25,
                FechaRegistro = DateTime.Now
            });
            TempData["LProductoTD"] = ProductoListTD;
            return View();


        }
    }
}
