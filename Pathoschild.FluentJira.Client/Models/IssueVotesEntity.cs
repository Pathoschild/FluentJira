namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents user votes on an issue with added information from its endpoint.</summary>
	public class IssueVotesEntity : IssueVotes
	{
		/// <summary>The users who have voted on the issue.</summary>
		public User[] Voters { get; set; }
	}
}