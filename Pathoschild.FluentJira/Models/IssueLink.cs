using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a relation between two issues.</summary>
	public class IssueLink : EntityWithID
	{
		/// <summary>The type of relation.</summary>
		public IssueLinkType Type { get; set; }

		/// <summary>The issue to which this issue has a relation.</summary>
		public Issue InwardIssue { get; set; }
	}
}