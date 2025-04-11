namespace AdminNotificator.Core.Domain;

public class UserDepartment
{
    /// <summary>Уникальный ИД</summary>
    public int Id { get; init; }

    /// <summary>Полное название</summary>
    public string TitleFull { get; init; }

    /// <summary>Краткое название</summary>
    public string TitleShort { get; init; }

    /// <summary>Код подразделения.</summary>
    public string Code { get; init; }

    /// <summary>Ид родительского отдела. Null - нет родителя</summary>
    public int? ParentDepartmentId { get; init; }

    /// <summary>
    ///     ИД сотрудника, который является руководителем подразделения
    /// </summary>
    public int? ManagerId { get; init; }
}