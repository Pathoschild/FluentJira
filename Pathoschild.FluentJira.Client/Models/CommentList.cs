using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
    /// <summary>A list of user comments.</summary>
    public class CommentList : EntityList
    {
        /// <summary>The user comments.</summary>
        public Comment[] Comments { get; set; }
    }
}