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
    public class IndexModel : PageModel
    {
        private readonly Aplicatie_Web.Data.Aplicatie_WebContext _context;

        public IndexModel(Aplicatie_Web.Data.Aplicatie_WebContext context)
        {
            _context = context;
        }

        public IList<Abonament> Abonament { get;set; }

        public async Task OnGetAsync()
        {
            Abonament = await _context.Abonament.ToListAsync();
        }
    }
}
