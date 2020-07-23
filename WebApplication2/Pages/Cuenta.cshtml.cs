using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;
using WebApplication2.DL;

namespace WebApplication2.Pages
{
    public class CuentaModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public Cuentas cuenta { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
          

            var modelo = cuenta;
            Data data = new Data();
            bool respuesta = await data.AltaCuenta(modelo);
            if (respuesta)
            {
                //ok redirect 
                return RedirectToPage("./Index");
            }
            else
            {
                //no ok, hay que mostrar mensaje de error
                ModelState.AddModelError(string.Empty, "Ocurrio un error al crear el anuncio");
                return Page();
            }

        }
    }
}