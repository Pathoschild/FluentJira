using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents user votes on an issue.</summary>
	public class IssueVotes : AddressableEntity
	{
		/// <summary>The number of votes on the issue.</summary>
		public int Votes { get; set; }

		/// <summary>Whether the current user has voted.</summary>
		public bool HasVoted { get; set; }
	}
}