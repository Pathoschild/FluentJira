using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A workflow step.</summary>
	public class Status : AddressableIdentifiableNamedEntity
	{
		/// <summary>The URL of the display icon for the status.</summary>
		public string IconUrl { get; set; }
	}
}