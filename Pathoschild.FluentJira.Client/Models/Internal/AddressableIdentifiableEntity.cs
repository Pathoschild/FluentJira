using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models.Internal
{
	/// <summary>A REST resource with a URL to itself (or its complete version in the case of a partial representation embedded in another resource) and a unique identifier.</summary>
	public abstract class AddressableIdentifiableEntity : AddressableEntity, IIdentifiableEntity
	{
		/// <summary>The unique key which identifies this entity from others of its type.</summary>
		public int ID { get; set; }
	}
}