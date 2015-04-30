namespace Pathoschild.FluentJira.Models
{
    /// <summary>Represents a specific change to a field value in an issue history.</summary>
    public class ChangeDetail
    {
        /// <summary>The field's name.</summary>
        public string Field { get; set; }

        /// <summary>The field's type (such as 'jira' or 'custom').</summary>
        public string FieldType { get; set; }

        /// <summary>The field's previous underlying value (such as a sprint ID). If the field is a string, this might be <c>null</c> in favour of <see cref="FromString"/>.</summary>
        public string From { get; set; }

        /// <summary>The field's previous value as a human-readable string (such as a sprint display name).</summary>
        public string FromString { get; set; }

        /// <summary>The field's new underlying value (such as a sprint ID). If the field is a string, this might be <c>null</c> in favour of <see cref="ToString"/>.</summary>
        public string To { get; set; }

        /// <summary>The field's new value as a human-readable string (such as a sprint display name).</summary>
        public string ToString { get; set; }
    }
}