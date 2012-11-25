using System;
using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models.Internal
{
	/// <summary>A REST resource with a URL to itself (or its complete version in the case of a partial representation embedded in another resource).</summary>
	public abstract class AddressableEntity : IAddressableEntity
	{
		/// <summary>The URL of the REST resource (or its complete version in the case of a partial representation embedded in another resource).</summary>
		public Uri Self { get; set; }
	}
}