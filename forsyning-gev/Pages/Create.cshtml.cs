using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using forsyning_gev.Data;
using forsyning_gev.Models;

namespace forsyning_gev.Pages
{
    public class CreateModel : PageModel
    {
        private readonly forsyning_gev.Data.Pentesterlab _context;

        public CreateModel(forsyning_gev.Data.Pentesterlab context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Spoof Spoof { get; set; } = default!;
        

        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Spoofer == null || Spoof == null)
            {
                return Page();
            }

            _context.Spoofer.Add(Spoof);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
