using System.ComponentModel.DataAnnotations;

namespace forsyning_gev.Models;

public class Spoof
{
	public int Id { get; set; }

	[Required]
	public string? Email { get; set; }
}