namespace Pathoschild.FluentJira.Models.Abstract
{
	/// <summary>Implements the generic fields exposed by JIRA lists.</summary>
	public abstract class EntityList
	{
		/// <summary>The index of the first item returned (0-based).</summary>
		public int StartAt { get; set; }

		/// <summary>The maximum number of items returned. If you specify a value that is higher than this number, your search results will be truncated.</summary>
		public int MaxResults { get; set; }

		/// <summary>The total number of items matching the search criteria.</summary>
		public int Total { get; set; }
	}
}