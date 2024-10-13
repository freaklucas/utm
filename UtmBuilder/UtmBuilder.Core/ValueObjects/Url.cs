using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{
    /// <summary>
    ///     Create new url
    /// </summary>
    /// <param name="address"></param>
    public Url(string address)
    {
        Address = address;

        InvalidUrlException.ThrowIfInvalid(Address);
    }

    /// <summary>
    ///     Address of url (website link)
    /// </summary>
    public string Address { get; }
}