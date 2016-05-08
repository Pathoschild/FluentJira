using System;
using System.Net.Http.Headers;
using System.Text;
using Pathoschild.Http.Client;

namespace Pathoschild.FluentJira
{
    /// <summary>Sends HTTP requests and receives responses from a JIRA REST API.</summary>
    public class JiraClient : FluentClient
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="baseUrl">The URL of the JIRA API, including the version (like <c>http://*/rest/api/latest/</c>).</param>
        public JiraClient(string baseUrl)
            : base(baseUrl) { }

        /// <summary>Construct an instance.</summary>
        /// <param name="baseUrl">The URL of the JIRA API, including the version (like <c>http://*/rest/api/latest/</c>).</param>
        /// <param name="username">The JIRA username with which to log in.</param>
        /// <param name="password">The JIRA password with which to log in.</param>
        /// <remarks>This adds headers for basic authentication. You can provide your own authentication mechanism through the <see cref="JiraClient.BaseClient"/>.</remarks>
        public JiraClient(string baseUrl, string username, string password)
            : this(baseUrl)
        {
            this.BaseClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"))
            );
        }
    }
}
