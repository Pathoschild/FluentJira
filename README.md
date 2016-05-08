**FluentJira** is a tiny framework for using [JIRA][]'s [REST API][JIRA REST API] from .NET. It provides a fluent interface for building API queries, and handles authentication and deserialisation into strongly-typed models.

This framework doesn't encapsulate the specific endpoint signatures, which means you can easily query any portion of the JIRA REST API (including addon APIs) without needing to change the HTTP client.

**This is an early development version.**

## Installing
The fluent client is [available on NuGet][]:
> Install-Package Pathoschild.FluentJira

This is a portable library compatible with multiple platforms (.NET 4.5+, Windows 8+ apps, Universal Windows Platform, and ASP.NET Core 1.0).

## Using the client
 which simplifies HTTP requests against the JIRA API and parsing the server responses. The structures returned by the client look like the actual API responses, so the [JIRA API documentation](http://docs.atlassian.com/jira/REST/latest/) is applicable.

You start by creating a client:

```c#
// create client
IClient client = new JiraClient("https://example.atlassian.net/rest/api/latest/", "username", "password");
```

Next you chain methods to define your API request, and deserialise the response into one of the predefined models (or your own model):

```c#
// fetch an issue
Issue issue = await client
    .Get("issue/EXAMPLE-14")
    .WithArgument("expand", "changelog")
    .As<Issue>();

// read the model
Console.WriteLine($@"
	'{issue.Fields.Summary}' has a remaining estimate of {issue.Fields.TimeTracking.RemainingEstimate}.
	It was last edited by {issue.ChangeLog.Histories.Last().Author.Name}.
");
```

### Self links
You can use JIRA's `Self` URLs to get further information on an object. For example, this code gets all the information for the user who posted an issue:
```c#
User user = client
    .Get(issue.Fields.Assignee.Self)
    .As<User>();
Console.WriteLine($"The assignee's timezone is {user.TimeZone}.");
```

This is a minimal extension of the [fluent HTTP client][FluentHttpClient]; see [its project page for more examples and documentation][FluentHttpClient].

[available on NuGet]: https://www.nuget.org/packages/Pathoschild.FluentJira
[JIRA]: http://www.atlassian.com/software/jira/overview
[JIRA REST API]: http://www.atlassian.com/software/jira/overview
[FluentHttpClient]: https://github.com/Pathoschild/FluentHttpClient