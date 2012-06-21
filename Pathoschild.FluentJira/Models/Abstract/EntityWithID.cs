namespace Pathoschild.FluentJira.Models.Abstract
{
	/// <summary>An object with its own API endpoint and unique identifier.</summary>
	public abstract class EntityWithID : Entity
	{
		/// <summary>The unique key which identifies this entity from others of its type.</summary>
		public int ID { get; set; }
	}
}