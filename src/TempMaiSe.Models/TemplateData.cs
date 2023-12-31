using System.Collections.ObjectModel;

namespace TempMaiSe.Models;

public class TemplateData
{
    public MailAddress? From { get; set; }

    public Collection<MailAddress> To { get; } = new();

    public Collection<MailAddress> Cc { get; } = new();

    public Collection<MailAddress> Bcc { get; } = new();

    public Collection<MailAddress> ReplyTo { get; } = new();

    public Collection<Tag> Tags { get; } = new();

    public Collection<Header> Headers { get; } = new();

    public required string SubjectTemplate { get; set; }

    public string? HtmlBodyTemplate { get; set; }

    public string? PlainTextBodyTemplate { get; set; }

    public Priority Priority { get; set; } = Priority.None;

    public required string JsonSchema { get; set; }
}
