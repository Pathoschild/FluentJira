using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models.Internal
{
    /// <summary>A REST resource with a URL to itself (or its complete version in the case of a partial representation embedded in another resource), a unique identifier, and a human-friendly display name and description.</summary>
    public abstract class AddressableIdentifiableNamedEntity : AddressableIdentifiableEntity, INamedEntity
    {
        /// <summary>The display name of the entity.</summary>
        public string Name { get; set; }

        /// <summary>The human-reable description of the entity.</summary>
        public string Description { get; set; }
    }
}