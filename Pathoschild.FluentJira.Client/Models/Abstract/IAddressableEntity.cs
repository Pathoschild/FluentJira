using System;

namespace Pathoschild.FluentJira.Models.Abstract
{
    /// <summary>A REST resource with a URL to itself (or its complete version in the case of a partial representation embedded in another resource).</summary>
    public interface IAddressableEntity
    {
        /// <summary>The URL of the REST resource (or its complete version in the case of a partial representation embedded in another resource).</summary>
        Uri Self { get; set; }
    }
}