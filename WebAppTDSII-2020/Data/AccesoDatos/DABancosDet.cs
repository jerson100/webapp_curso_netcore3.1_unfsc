using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTDSII_2020.Models;

namespace WebAppTDSII_2020.Data.AccesoDatos
{
    public class DABancosDet
    {
        public IEnumerable<BancosDet> GetBancosDet()
        {
            var listado = new List<BancosDet>();
            //Se ejecuta para liberar el recurso
            using(var db = new ApplicationDbContext())
            {
                listado = db.BancosDet.Include(item => item.BancosCab).ToList();
            }
            return listado;
        }

        public BancosDet GetIdBancosDet(int id)
        {
            var resultado = new BancosDet();
            using (var db = new ApplicationDbContext())
            {
                resultado = db.BancosDet.Where(item => item.IdBancosDet == id).FirstOrDefault();
            }
            return resultado;
        }

        public IEnumerable<BancosDet> GetBancosDet(int idBancosCab, int month)
        {
            var listado = new List<BancosDet>();
            using (var db = new ApplicationDbContext())
            {
                listado = db.BancosDet
                                .Include(item => item.BancosCab)
                                .Where(item => item.IdBancosCab == idBancosCab && item.FechaRegistro.Month == month)
                                .ToList();
            }
            return listado;
        }

        public int InsertBancosDet(BancosDet Entidad)
        {
            var resultado = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(Entidad); //Selecciona la fila del registro
                db.SaveChanges(); //Guarda en la DB 
                resultado = Entidad.IdBancosDet;
            }
            return resultado;
        }

        public Boolean UpdateBancosDet(BancosDet Entity)
        {
            var Resultado = false; 
            using(var db = new ApplicationDbContext())
            {
                db.BancosDet.Attach(Entity); //Referencia a la entidad
                db.Entry(Entity).State = EntityState.Modified; //Marca toda la fila y actualiza los campos
                db.Entry(Entity).Property(Item => Item.FechaRegistro).IsModified = false; // Excluyo el campo FechaRegistro para la modificación
                Resultado = db.SaveChanges() != 0; //guarda en a DB 
            }
            return Resultado;
        }
    }
}
