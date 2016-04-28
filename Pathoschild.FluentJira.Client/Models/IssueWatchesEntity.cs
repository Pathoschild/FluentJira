namespace Pathoschild.FluentJira.Models
{
    /// <summary>Metadata about users notified when the issue is updated, with additional details from its endpoint.</summary>
    public class IssueWatchesEntity : IssueWatches
    {
        /// <summary>The users who are notified when this issue is updated.</summary>
        public User[] Watchers { get; set; }
    }
}