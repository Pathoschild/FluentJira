namespace Pathoschild.FluentJira.Models.Abstract
{
	/// <summary>An object with its own API endpoint.</summary>
	public abstract class Entity
	{
		/// <summary>The absolute URL of the API method which returns further details about this entity.</summary>
		public string Self { get; set; }
	}
}