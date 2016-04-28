using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
    /// <summary>Represents a relation between two issues.</summary>
    public class IssueLink : AddressableIdentifiableEntity
    {
        /// <summary>The type of relation.</summary>
        public IssueLinkType Type { get; set; }

        /// <summary>The issue to which this issue has a relation.</summary>
        public Issue InwardIssue { get; set; }
    }
}