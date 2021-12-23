using ProjectAveryCommon.Model.Entity.Pocos.Player;
using ProjectAveryCommon.Model.Privileges;
using ProjectAveryCommon.Model.Privileges.Entity.ReadEntity.ReadConsoleTab;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications.PlayerNotifications;

/// <summary>
/// Update a player on the playerlist 
/// </summary>
[Privileges(typeof(ReadPlayerlistConsoleTabPrivilege))]
public class UpdatePlayerNotification : AbstractEntityNotification
{
    public ServerPlayer ServerPlayer { get; set; }
}