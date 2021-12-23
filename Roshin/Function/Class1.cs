namespace MySQLapp.Utils
{
    public class User
{

    /// <summary>
    /// Идентификатор пользователя в БД (<c>nullable</c>).
    /// </summary>
    public ushort? ID_SEC { get; }
    /// <summary>
    /// ФИО Пользователя
    /// </summary>
    public string FIO { get; }
    /// <summary>
    /// Должность пользователя (<c>nullable</c>).
    /// </summary>
    public string FIONepolnoe { get; }
    /// <summary>
    /// Сокрощеное имя.
    /// </summary>
    public string Dolg { get; }
    /// <summary>
    /// Логин пользователя.
    /// </summary>
    public string Login { get; }
    /// <summary>
    /// Пароль пользователя.
    /// </summary>
    public string Password { get; }
    /// <summary>
    /// Уровень Пользователя.
    /// </summary>
    public string Level { get; }
    /// <summary>
    /// Адрес пользователя.
    /// </summary>
    public string Mesto { get; }
    /// <summary>
    /// Назначение пользователя в системе.
    /// </summary>

    public User(ushort id_sec, string fio, string fion, string dolg, string login, string password, string level, string mesto)
    {
        ID_SEC = id_sec;
        FIO = fio;
        Dolg = dolg;
        Login = login;
        Password = password;
        Level = level;
        Mesto = mesto;
        FIONepolnoe = fion;

    }

}
}