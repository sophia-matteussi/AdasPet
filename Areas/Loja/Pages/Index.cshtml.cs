using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Loja.Pages
{
    public class IndexModel : PageModel
    {
        public string Animal { get; set; }
        public string Categoria { get; set; }

        public void OnGet(string animal, string categoria)
        {
        }
    }
}
