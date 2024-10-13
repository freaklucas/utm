using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core;

public class Utm
{
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    /// <summary>
    ///     URL (weksite link)
    /// </summary>
    public Url Url { get; }

    /// <summary>
    ///     Campaign Details
    /// </summary>
    public Campaign Campaign { get; }

    public static implicit operator string(Utm utm)
    {
        return utm.ToString();
    }

    public override string ToString()
    {
        var segments = new List<string>();

        segments.AddIfNotNull("utm_source", Campaign.Source);
        segments.AddIfNotNull("utm_medium", Campaign.Medium);
        segments.AddIfNotNull("utm_campaign", Campaign.Name);
        segments.AddIfNotNull("utm_id", Campaign.Id ?? string.Empty);
        segments.AddIfNotNull("utm_term", Campaign.Term ?? string.Empty);
        segments.AddIfNotNull("utm_content", Campaign.Content ?? string.Empty);

        return $"{Url.Address}?{string.Join("&", segments)}";
    }

    /* https://lucasol.vercel.app
    utm_source=lucasol
    utm_medium=blog&
    utm_campaign=LUC10OFF
    utm_id=LC&
    utm_content=post-sobre-carreira */
}

public class X
{
    public void Y()
    {
        var campaign = new Campaign("lucasol", "blog", "campanha do blog");
        var url = new Url("www.lucas.com");
        var utm = new Utm(url, campaign);

        string resultado = utm;
    }
}