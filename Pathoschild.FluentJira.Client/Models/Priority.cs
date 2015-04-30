using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>The relative priority of an issue.</summary>
	public class Priority : AddressableIdentifiableEntity
	{
		/// <summary>The display name of the priority.</summary>
		public string Name { get; set; }

		/// <summary>The URL of the display icon.</summary>
		public string IconUrl { get; set; }
	}
}