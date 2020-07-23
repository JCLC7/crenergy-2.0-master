using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Pages
{
    public class CarritoModel : PageModel
    {
        private readonly ILogger<CarritoModel> _logger;

        public CarritoModel(ILogger<CarritoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
