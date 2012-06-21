using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>Represents a list of user groups.</summary>
	public class GroupList
	{
		/// <summary>The number of groups in the list.</summary>
		public int Size { get; set; }

		/// <summary>The user groups.</summary>
		public Group[] Items { get; set; }
	}
}
