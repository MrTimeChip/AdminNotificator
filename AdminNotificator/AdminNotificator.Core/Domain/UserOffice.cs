namespace AdminNotificator.Core.Domain;

public class UserOffice
{
    /// <summary>Уникальный ИД</summary>
    public int Id { get; init; }

    /// <summary>Адрес</summary>
    public string Address { get; init; }

    /// <summary>Город</summary>
    public string Town { get; init; }
}