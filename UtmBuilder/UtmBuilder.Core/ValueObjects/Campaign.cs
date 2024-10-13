using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    /// <summary>
    ///     generate new campaign for a url
    /// </summary>
    /// <param name="source">the refer ( e.g. google, newsletter)</param>
    /// <param name="medium">marketing medium (e.g. cpg, banner, email)</param>
    /// <param name="name">Product promo code, or slogan (e.g. spring_sale)</param>
    /// <param name="id">id campaign </param>
    /// <param name="term">identify the paid keywords</param>
    /// <param name="content">use to differentiate ads</param>
    public Campaign(
        string source,
        string medium,
        string name,
        string? id = null,
        string? term = null,
        string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;

        Id = id;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfNull(source, "Source not found");
        InvalidCampaignException.ThrowIfNull(medium, "Medium not found");
        InvalidCampaignException.ThrowIfNull(name, "Name not found");
    }

    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string? Id { get; }
    public string? Term { get; }
    public string? Content { get; }
}