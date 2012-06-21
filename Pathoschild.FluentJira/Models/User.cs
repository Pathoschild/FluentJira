using System.Collections.Generic;
using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a person in JIRA.</summary>
	public class User : Entity
	{
		/// <summary>The unique identifying key.</summary>
		public string Name { get; set; }

		/// <summary>The user's display name.</summary>
		public string DisplayName { get; set; }

		/// <summary>The user's email address.</summary>
		public string EmailAddress { get; set; }

		/// <summary>The URLs for this user's avatar in different sizes.</summary>
		public IDictionary<string, string> AvatarUrls { get; set; }

		/// <summary>The name of the user's timezone, like "America/Montreal".</summary>
		public string TimeZone { get; set; }

		/// <summary>The groups of which this user is a member.</summary>
		public GroupList Groups { get; set; }

		/// <summary>Whether the user is active in the system.</summary>
		public bool Active { get; set; }
	}
}