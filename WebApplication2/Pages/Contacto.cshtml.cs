using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;


namespace WebApplication2.Pages
{
    public class ContactoModel : PageModel
    {
      

         public void OnGet()
        {

        }

        [BindProperty]
        public Contacto Contacto { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var modelo = Contacto;

       
            //_context.Customers.Add(Customer);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}