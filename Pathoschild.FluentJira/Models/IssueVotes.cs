using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents user votes on an issue.</summary>
	public class IssueVotes : Entity
	{
		/// <summary>The number of votes on the issue.</summary>
		public int Votes { get; set; }

		/// <summary>Whether the current user has voted.</summary>
		public bool HasVoted { get; set; }
	}
}