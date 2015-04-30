using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents search results returned by the /search endpoint.</summary>
	public class IssueList : EntityList
	{
		/// <summary>The issues matched by the search.</summary>
		public Issue[] Issues { get; set; }
	}
}