namespace Pathoschild.FluentJira.Models.Abstract
{
    /// <summary>A REST resource with a unique identifier.</summary>
    public interface IIdentifiableEntity
    {
        /// <summary>The unique key which identifies this entity from others of its type.</summary>
        int ID { get; set; }
    }
}