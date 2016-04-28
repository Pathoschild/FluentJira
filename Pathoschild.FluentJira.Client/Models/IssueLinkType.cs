using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
    /// <summary>Represents a type of relation between two issues.</summary>
    public class IssueLinkType : AddressableIdentifiableEntity
    {
        /// <summary>The display name of the issue link type.</summary>
        public string Name { get; set; }

        /// <summary>The descriptive name of a relation <em>to</em> this item (like "is blocked by").</summary>
        public string Inward { get; set; }

        /// <summary>The descriptive name of a relation <em>from</em> this item (like "blocks").</summary>
        public string Outward { get; set; }
    }
}