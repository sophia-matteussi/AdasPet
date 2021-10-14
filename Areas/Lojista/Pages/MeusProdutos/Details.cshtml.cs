﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdasPet.Data;
using AdasPet.Models;

namespace AdasPet.Areas.Lojista.Pages.MeusProdutos
{
    public class DetailsModel : PageModel
    {
        private readonly AdasPet.Data.ApplicationDbContext _context;

        public DetailsModel(AdasPet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.ID == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
