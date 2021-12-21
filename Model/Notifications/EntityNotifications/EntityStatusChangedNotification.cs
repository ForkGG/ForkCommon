using ProjectAveryCommon.Model.Entity.Enums;
using ProjectAveryCommon.Model.Privileges;
using ProjectAveryCommon.Model.Privileges.Entity.ReadEntity;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications;

[Privileges(typeof(IReadEntityPrivilege))]
public class EntityStatusChangedNotification : AbstractEntityNotification
{
    public EntityStatus NewEntityStatus { get; set; }
}