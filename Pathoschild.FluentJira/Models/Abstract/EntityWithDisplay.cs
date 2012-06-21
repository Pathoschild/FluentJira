namespace Pathoschild.FluentJira.Models.Abstract
{
	/// <summary>An object with its own API endpoint, unique identifier, and human-friendly display name and description.</summary>
	public abstract class EntityWithDisplay : EntityWithID
	{
		/// <summary>The display name of the entity.</summary>
		public string Name { get; set; }

		/// <summary>The display description of the entity.</summary>
		public string Description { get; set; }
	}
}