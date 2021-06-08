﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster5.Data;
using RazorPagesMonster5.Models;

namespace RazorPagesMonster5.Pages.Monsters
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMonster5.Data.RazorPagesMonster5Context _context;

        public DetailsModel(RazorPagesMonster5.Data.RazorPagesMonster5Context context)
        {
            _context = context;
        }

        public Monster Monster { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monster = await _context.Monster.FirstOrDefaultAsync(m => m.ID == id);

            if (Monster == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
