using System.ComponentModel.DataAnnotations;

namespace TextSplitterApp.Models
{
	/// <summary>
	/// A model for the text view
	/// </summary>
	public class TextViewModel
	{
		/// <summary>
		/// Raw text.
		/// </summary>
		[Required]
		[StringLength(30, MinimumLength = 2)]
		public string Text { get; set; } = string.Empty;

		/// <summary>
		/// Split text.
		/// </summary>
		public string SplitText { get; set; } = string.Empty;
	}
}
