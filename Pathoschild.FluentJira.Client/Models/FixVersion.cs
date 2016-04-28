using System;
using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
    /// <summary>Represents a product version for which issues can be planned.</summary>
    public class FixVersion : AddressableIdentifiableNamedEntity
    {
        /// <summary>The date on which the release is scheduled for completion.</summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>Whether the version is archived and no longer active.</summary>
        public bool Archived { get; set; }

        /// <summary>Whether the version has already been completed and released.</summary>
        public bool Released { get; set; }
    }
}