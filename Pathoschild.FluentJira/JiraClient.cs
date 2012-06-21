using System;
using System.Net.Http.Headers;
using System.Text;
using Pathoschild.DesignByContract;
using Pathoschild.FluentJira.Models;
using Pathoschild.Http.FluentClient;
using Pathoschild.Http.Formatters.JsonNet;

namespace Pathoschild.FluentJira
{
	/// <summary>Sends HTTP requests and receives responses from a JIRA REST API.</summary>
	public class JiraClient : Pathoschild.Http.FluentClient.Default.Client
	{
		/*********
		** Public methods
		*********/
		/// <summary>Construct an instance.</summary>
		/// <param name="baseUrl">The URL of the JIRA API, including the version (like <c>http://*/rest/api/latest/</c>).</param>
		public JiraClient([NotNull, NotBlank] string baseUrl)
			: base(baseUrl)
		{
			this.Formatters.Clear();
			this.Formatters.Add(new JsonNetFormatter());
		}

		/// <summary>Construct an instance.</summary>
		/// <param name="baseUrl">The URL of the JIRA API, including the version (like <c>http://*/rest/api/latest/</c>).</param>
		/// <param name="username">The JIRA username with which to log in.</param>
		/// <param name="password">The JIRA password with which to log in.</param>
		/// <remarks>This adds headers for basic authentication. You can provide your own authentication mechanism through the <see cref="JiraClient.BaseClient"/>.</remarks>
		public JiraClient([NotNull, NotBlank] string baseUrl, [NotNull, NotBlank] string username, [NotNull, NotBlank] string password)
			: this(baseUrl)
		{
			this.BaseClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
				"Basic",
				Convert.ToBase64String(
					Encoding.UTF8.GetBytes(
						String.Format("{0}:{1}", username, password)
					)
				)
			);
		}
	}
}
