using ProjectAveryCommon.Model.Entity.Transient.Console;
using ProjectAveryCommon.Model.Privileges;
using ProjectAveryCommon.Model.Privileges.Entity.ReadEntity.ReadConsoleTab;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications;

[Privileges(typeof(ReadConsoleConsoleTabPrivilege))]
public class ConsoleAddNotification : AbstractEntityNotification
{
    // The message that was added to the console
    public ConsoleMessage NewConsoleMessage { get; set; }
}