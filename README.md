Pathoschild.FluentJira
=====================

A strongly-typed, fluent HTTP client for [JIRA](http://www.atlassian.com/software/jira/overview)'s [REST API](http://docs.atlassian.com/jira/REST/latest/) using the .NET 4.5 HttpClient.

**This is an early development version.**

## Usage
This client is an extension of [`Pathoschild.FluentHttpClient`](https://github.com/Pathoschild/Pathoschild.FluentHttpClient), so you can execute any HTTP request against the API and get a strongly-typed response. The structures returned by the client look like the actual API responses, so the [JIRA API documentation](http://docs.atlassian.com/jira/REST/latest/) is entirely relevant.

### Example
```c#
// create client
IClient client = new Client("https://example.atlassian.net/rest/api/latest/"); // there's an optional overload for username & password

// retrieve an issue
 Issue issue = client
    .Get("issue/EXAMPLE-14")
    .RetrieveAs<Issue>();

// use the data
string summary = issue.Fields.Summary; // "This is an example issue title"
string estimate = issue.Fields.TimeTracking.RemainingEstimate; // "2d 4h"
int estimateSeconds = issue.Fields.TimeTracking.RemainingEstimate; // 187200

// really use the data
string emailOfFirstCommenter = issue.Fields.Comments.Comments.First().Author.EmailAddress;
```

### Self links
The client also recognizes the `Self` URLs that link to further information on an object. For example, this code gets all the information for the user who posted the above issue:
```c#
// this is the issue we have above
Issue issue = ...;

// it already basic user information
User basicUser = issue.Fields.Assignee;
string username = basicUser.Name;
string email = basicUser.EmailAddress;

// but you can also retrieve the full description
User user = client
    .Get(basicUser.Self)
    .RetrieveAs<User>();

string timeZone = user.TimeZone; // "America/Montreal"
IEnumerable<string> groups = user.Groups.Items.Select(p => p.Name); // ["administrators", "developers", "users"]
```

For further information, see the [`Pathoschild.FluentHttpClient` documentation](https://github.com/Pathoschild/Pathoschild.FluentHttpClient).