using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A list of worklog entries.</summary>
	public class WorklogList : EntityList
	{
		/// <summary>The worklog entries.</summary>
		public WorkLog[] WorkLogs { get; set; }
	}
}