using ProjectAvery.Logic.Model;
using ProjectAvery.Logic.Model.Enums;
using ProjectAveryCommon.Model.Entity.Transient.Console;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications;

[Privileges(Privilege.ReadConsoleTabConsole)]
public class ConsoleAddNotification : AbstractEntityNotification
{
    // The message that was added to the console
    public ConsoleMessage NewConsoleMessage { get; set; }
}