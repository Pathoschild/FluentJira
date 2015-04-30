namespace Pathoschild.FluentJira.Models.Abstract
{
	/// <summary>A REST resource with a display name.</summary>
	public interface INamedEntity
	{
		/// <summary>The display name of the entity.</summary>
		string Name { get; set; }
	}
}