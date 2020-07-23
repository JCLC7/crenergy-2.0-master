using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Contacto
    { 
    
            public int Id { get; set; }

            [Required, StringLength(10)]
            public string Name { get; set; }

            [Required, EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Subject { get; set; }

         
            public string Texto { get; set; }


      
    }
}
