using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents the type of an issue (such as "task" or "user story").</summary>
	public class IssueType : AddressableIdentifiableNamedEntity
	{
		/// <summary>The URL of the display icon.</summary>
		public string IconUrl { get; set; }

		/// <summary>Whether the issue type is for subtasks.</summary>
		public bool Subtask { get; set; }
	}
}