using forsyning_gev.Data;
using forsyning_gev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace forsyning_gev.Pages;

public class IndexModel : PageModel
{
	private readonly Pentesterlab _context;

	public IndexModel(Pentesterlab context)
	{
		_context = context;
	}

	[BindProperty] public Spoof Spoof { get; set; } = default!;


	public async Task<IActionResult> OnPostAsync()
	{
		if (!ModelState.IsValid || _context.Spoofer == null || Spoof == null) return Page();

		_context.Spoofer.Add(Spoof);
		await _context.SaveChangesAsync();

		return RedirectToPage("./Redirect");
	}
}