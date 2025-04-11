namespace AdminNotificator.Core.Domain;

public class UserPosition
{
    /// <summary>
    ///    Наименование организации
    /// </summary>
    public string OrganizationShortname { get; init; }

    /// <summary>
    ///     Должность
    /// </summary>
    public string Post { get; init; }
}