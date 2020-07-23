using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.DL
{
    public class Data
    {
        public async Task<bool>  AltaAnuncio (AltaAnuncios anuncioNunevo)
        {
            try
            {   
                wEservicesContext context = new wEservicesContext();
                context.AltaAnuncios.Add(anuncioNunevo);
                await context.SaveChangesAsync();
                //_context.Customers.Add(Customer);
                //await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> AltaCuenta(Cuentas cuentaNueva)
        {
            try
            {
                wEservicesContext context = new wEservicesContext();
                context.Cuentas.Add(cuentaNueva);
                await context.SaveChangesAsync();
                //_context.Customers.Add(Customer);
                //await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
