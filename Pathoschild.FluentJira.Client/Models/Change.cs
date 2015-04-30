using System;
using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
    /// <summary>Represents a change from an issue's history.</summary>
    public class Change : IdentifiableEntity
    {
        /// <summary>The person who made this change.</summary>
        public User Author { get; set; }

        /// <summary>When the change was made.</summary>
        public DateTime Created { get; set; }

        /// <summary>The specific field changes.</summary>
        public ChangeDetail[] Items { get; set; }
    }
}