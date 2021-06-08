using System;
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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMonster5.Data.RazorPagesMonster5Context _context;

        public DeleteModel(RazorPagesMonster5.Data.RazorPagesMonster5Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monster = await _context.Monster.FindAsync(id);

            if (Monster != null)
            {
                _context.Monster.Remove(Monster);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
