namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents overall progress towards completion.</summary>
	public class ProgressValue
	{
		/// <summary>The number of seconds logged.</summary>
		public int Progress { get; set; }

		/// <summary>The number of seconds estimated.</summary>
		public int Total { get; set; }

		/// <summary>The percentage completion based on the actual versus estimated completion time.</summary>
		public long Percent { get; set; }
	}
}