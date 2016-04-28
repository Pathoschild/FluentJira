namespace Pathoschild.FluentJira.Models
{
    /// <summary>Data on logged and estimated work time.</summary>
    public class IssueTimeTracking
    {
        /// <summary>The total estimated time to complete this ticket.</summary>
        public string OriginalEstimate { get; set; }

        /// <summary>The remaining estimated time to complete this ticket.</summary>
        public string RemainingEstimate { get; set; }

        /// <summary>The total time spent working on this ticket.</summary>
        public string TimeSpent { get; set; }

        /// <summary>The total estimated time to complete this ticket (in seconds).</summary>
        public int OriginalEstimateSeconds { get; set; }

        /// <summary>The remaining estimated time to complete this ticket (in seconds).</summary>
        public int RemainingEstimateSeconds { get; set; }

        /// <summary>The total time spent working on this ticket (in seconds).</summary>
        public int TimeSpentSeconds { get; set; }
    }
}