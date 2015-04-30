using System;
using Pathoschild.FluentJira.Models.Internal;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a file attached to an issue.</summary>
	public class Attachment : AddressableIdentifiableEntity
	{
		/// <summary>The name of the file.</summary>
		public string Filename { get; set; }

		/// <summary>The user who attached the file.</summary>
		public User Author { get; set; }

		/// <summary>When the attachment was uploaded.</summary>
		public DateTime Created { get; set; }

		/// <summary>The size of the attached file (in bytes?).</summary>
		public long Size { get; set; }

		/// <summary>The MIME type which represents the file format.</summary>
		public string MimeType { get; set; }

		/// <summary>The URL of the attached file.</summary>
		public string Content { get; set; }
	}
}