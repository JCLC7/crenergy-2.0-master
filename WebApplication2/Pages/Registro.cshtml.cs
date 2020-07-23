using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly ILogger<RegistroModel> _logger;

        public RegistroModel(ILogger<RegistroModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
