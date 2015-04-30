using System;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents additional issue fields.</summary>
	public class IssueFields
	{
		/***
		** Content
		***/
		/// <summary>The title of the issue.</summary>
		public string Summary { get; set; }

		/// <summary>The body content which describes the issue.</summary>
		public string Description { get; set; }

		/// <summary>The files attached to this issue.</summary>
		public Attachment[] Attachment { get; set; }

		/// <summary>The user comments on this issue.</summary>
		public CommentList Comments { get; set; }


		/***
		** Metadata
		***/
		/// <summary>The issue type (such as "task" or "user story").</summary>
		public IssueType IssueType { get; set; }

		/// <summary>The project which contains the issue.</summary>
		public Project Project { get; set; }

		/// <summary>The ticket's JIRA components.</summary>
		public Component[] Components { get; set; }

		/// <summary>The issue's parent, if this is a subtask.</summary>
		public Issue Parent { get; set; }

		/// <summary>The person who reported the issue.</summary>
		public User Reporter { get; set; }

		/// <summary>The person who is tasked with handling the issue.</summary>
		public User Assignee { get; set; }

		/// <summary>The tags on this issue.</summary>
		public string[] Labels { get; set; }

		/// <summary>The user votes on the issue.</summary>
		public IssueVotes Votes { get; set; }

		/// <summary>Metadata about users notified when the issue is updated.</summary>
		public IssueWatches Watches { get; set; }


		/*********
		** Workflow
		*********/
		/// <summary>The relative priority of the issue.</summary>
		public Priority Priority { get; set; }

		/// <summary>The issue resolution such as "Fixed" or "Duplicate".</summary>
		public Resolution Resolution { get; set; }

		/// <summary>The product versions for which the issue is planned.</summary>
		public FixVersion[] FixVersions { get; set; }

		/// <summary>The issue's workflow step.</summary>
		public Status Status { get; set; }

		/// <summary>When the issue was resolved, or <c>null</c> if it's unresolved.</summary>
		public DateTime? ResolutionDate { get; set; }

		/// <summary>When the issue was created.</summary>
		public DateTime Created { get; set; }

		/// <summary>When the issue was updated.</summary>
		public DateTime Updated { get; set; }


		/***
		** Work tracking
		***/
		/// <summary>The overall progress made towards completing the issue.</summary>
		public ProgressValue Progress { get; set; }

		/// <summary>The amount of time planned and logged for this ticket.</summary>
		public IssueTimeTracking TimeTracking { get; set; }

		/// <summary>The total original estimate in seconds for this ticket, including the sum of all subtasks.</summary>
		public int? AggregateTimeOriginalEstimate { get; set; }

		/// <summary>The work logged for this issue.</summary>
		public WorklogList WorkLog { get; set; }

		/// <summary>The overall progress made towards completing the issue, including all subtasks.</summary>
		public ProgressValue AggregateProgress { get; set; }

		/// <summary>The total time spent working on this ticket (in seconds).</summary>
		public int? TimeSpent { get; set; }

		/// <summary>The total estimated time to complete this ticket (in seconds).</summary>
		public int? TimeOriginalEstimate { get; set; }

		/// <summary>The total time spent working on this ticket, including subtasks (in seconds).</summary>
		public int? AggregateTimeSpent { get; set; }

		/// <summary>The percentage ratio of logged to estimated work (e.g., 2h logged with 1h estimated => 200).</summary>
		public long? WorkRatio { get; set; }
	}
}