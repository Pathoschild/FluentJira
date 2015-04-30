using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Metadata about users notified when the issue is updated.</summary>
	public class IssueWatches : AddressableEntity
	{
		/// <summary>The number of users watching the issue.</summary>
		public int WatchCount { get; set; }

		/// <summary>Whether the current user is watching the issue.</summary>
		public bool IsWatching { get; set; }
	}
}