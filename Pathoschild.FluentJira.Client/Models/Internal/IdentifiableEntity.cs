using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models.Internal
{
    /// <summary>A REST resource with a unique identifier.</summary>
    public abstract class IdentifiableEntity : IIdentifiableEntity
    {
        /// <summary>The unique key which identifies this entity from others of its type.</summary>
        public int ID { get; set; }
    }
}