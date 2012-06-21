using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A JIRA project.</summary>
	public class Project : EntityWithID
	{
		/// <summary>The unique key prefixed to issue keys in the project.</summary>
		public string Key { get; set; }

		/// <summary>The display name of the project.</summary>
		public string Name { get; set; }
	}
}