﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Danci_Natalia_MP_Lab2.Data;
using Danci_Natalia_MP_Lab2.Models;

namespace Danci_Natalia_MP_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Danci_Natalia_MP_Lab2.Data.Danci_Natalia_MP_Lab2Context _context;

        public IndexModel(Danci_Natalia_MP_Lab2.Data.Danci_Natalia_MP_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}