using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a set of changes from an issue's history.</summary>
	public class ChangeList : EntityList
	{
		/// <summary>The issues matched by the search.</summary>
		public Change[] Histories { get; set; }
	}
}