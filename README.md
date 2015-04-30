**FluentJira** is a tiny framework for using [JIRA](http://www.atlassian.com/software/jira/overview)'s
[REST API](http://docs.atlassian.com/jira/REST/latest/) from C#. It handles authentication and maps
REST responses to strongly-typed models, but you're still responsible for building the API call.
This is by design — you're not constrained to the operations abstracted by the client, and you can
query custom addon APIs that aren't added to the client library (by passing in custom models).

**This is an early development version.**

## Usage
This client is an extension of [`FluentHttpClient`](https://github.com/Pathoschild/Pathoschild.FluentHttpClient),
so you can execute any HTTP request against the API and get a strongly-typed response. The
structures returned by the client look like the actual API responses, so the [JIRA API documentation](http://docs.atlassian.com/jira/REST/latest/)
is applicable.

### Example
```c#
// create client
IClient client = new JiraClient("https://example.atlassian.net/rest/api/latest/", "username", "password");

// fetch the default issue fields
Issue issue = await client
    .Get("issue/EXAMPLE-14")
    .As<Issue>();
Console.WriteLine("'{0}' has a remaining estimate of {1}.", issue.Fields.Summary, issue.Fields.TimeTracking.RemainingEstimate);

// fetch the issue's change history
Issue issue = await client
    .Get("issue/EXAMPLE-14")
    .WithArgument("expand", "changelog")
    .As<Issue>();
Change change = issue.ChangeLog.Histories.Last();
Console.WriteLine("The issue was last edited by {0} at {1}.", change.Author.Name, change.Created);
```

### Self links
The client recognizes JIRA's `Self` URLs that link to further information on an object. For
example, this code gets all the information for the user who posted an issue:
```c#
User user = client
    .Get(issue.Fields.Assignee.Self)
    .RetrieveAs<User>();
Console.WriteLine("The assignee's timezone is {0}.", user.TimeZone);
```

For further information, see the [`FluentHttpClient` documentation](https://github.com/Pathoschild/Pathoschild.FluentHttpClient).