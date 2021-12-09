using ProjectAveryCommon.Model.Entity.Transient.Console;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications;

public class ConsoleAddNotification : AbstractEntityNotification
{
    // The message that was added to the console
    public ConsoleMessage NewConsoleMessage { get; set; }
}