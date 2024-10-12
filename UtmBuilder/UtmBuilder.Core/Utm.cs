using UtmBuilder.Core.ValueObjects;

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
}