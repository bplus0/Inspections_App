using System.ComponentModel.DataAnnotations;

namespace Inspections.API.Models
{
	public class Status
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string StatusOption { get; set; } = "";
	}
}
