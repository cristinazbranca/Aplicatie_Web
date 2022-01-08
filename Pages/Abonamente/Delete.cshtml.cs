﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Web.Data;
using Aplicatie_Web.Models;

namespace Aplicatie_Web.Pages.Abonamente
{
    public class DeleteModel : PageModel
    {
        private readonly Aplicatie_Web.Data.Aplicatie_WebContext _context;

        public DeleteModel(Aplicatie_Web.Data.Aplicatie_WebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Abonament Abonament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonament = await _context.Abonament.FirstOrDefaultAsync(m => m.AbonamentID == id);

            if (Abonament == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonament = await _context.Abonament.FindAsync(id);

            if (Abonament != null)
            {
                _context.Abonament.Remove(Abonament);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
