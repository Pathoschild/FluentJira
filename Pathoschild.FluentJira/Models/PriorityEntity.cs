namespace Pathoschild.FluentJira.Models
{
	/// <summary>The relative priority of an issue with additional details provided by its endpoint.</summary>
	public class PriorityEntity : Priority
	{
		/// <summary>The display description of the entity.</summary>
		public string Description { get; set; }

		/// <summary>The HTML colour code representing this priority.</summary>
		public string StatusColor { get; set; }
	}
}