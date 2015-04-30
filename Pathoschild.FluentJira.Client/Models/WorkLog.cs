using System;
using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A worklog entry that indicates work done.</summary>
	public class WorkLog : AddressableIdentifiableEntity
	{
		/// <summary>The user who created the entry.</summary>
		public User Author { get; set; }

		/// <summary>The last user who changed the entry.</summary>
		public User UpdateAuthor { get; set; }

		/// <summary>The input text describing the work done.</summary>
		public string Comment { get; set; }

		/// <summary>When the entry was created.</summary>
		public DateTime Created { get; set; }

		/// <summary>When the entry was modified.</summary>
		public DateTime Updated { get; set; }

		/// <summary>When the logged work was started.</summary>
		public DateTime Started { get; set; }

		/// <summary>The amount of time logged (in human-readable format).</summary>
		public string TimeSpent { get; set; }

		/// <summary>The amount of time logged (in seconds).</summary>
		public int TimeSpentSeconds { get; set; }
	}
}