using System;
using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a user's comment on an issue.</summary>
	public class Comment : AddressableIdentifiableEntity
	{
		/// <summary>The user who created the comment.</summary>
		public User Author { get; set; }

		/// <summary>The user who last edited the comment.</summary>
		public User UpdateAuthor { get; set; }

		/// <summary>When the comment was created.</summary>
		public DateTime Created { get; set; }

		/// <summary>When the comment was last modified.</summary>
		public DateTime Updated { get; set; }

		/// <summary>The content of the comment.</summary>
		public string Body { get; set; }
	}
}