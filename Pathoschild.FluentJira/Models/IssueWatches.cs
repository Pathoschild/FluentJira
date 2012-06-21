using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Metadata about users notified when the issue is updated.</summary>
	public class IssueWatches : Entity
	{
		/// <summary>The number of users watching the issue.</summary>
		public int WatchCount { get; set; }

		/// <summary>Whether the current user is watching the issue.</summary>
		public bool IsWatching { get; set; }
	}
}