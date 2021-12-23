using ProjectAveryCommon.Model.Entity.Enums.Player;
using ProjectAveryCommon.Model.Entity.Pocos.Player;
using ProjectAveryCommon.Model.Privileges;
using ProjectAveryCommon.Model.Privileges.Entity.ReadEntity.ReadConsoleTab;

namespace ProjectAveryCommon.Model.Notifications.EntityNotifications.PlayerNotifications;

/// <summary>
/// Updates a Player on the Banlist (add, remove or update)
/// </summary>
[Privileges(typeof(ReadBanlistConsoleTabPrivilege))]
public class UpdateBanlistPlayerNotification : AbstractEntityNotification
{
    public PlayerlistUpdateType UpdateType { get; set; }
    public Player Player { get; set; }
}