using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A JIRA issue.</summary>
	public class Issue : AddressableIdentifiableEntity
	{
		/// <summary>The unique string which identifies this issue.</summary>
		public string Key { get; set; }

		/// <summary>The additional issue fields.</summary>
		public IssueFields Fields { get; set; }
	}
}