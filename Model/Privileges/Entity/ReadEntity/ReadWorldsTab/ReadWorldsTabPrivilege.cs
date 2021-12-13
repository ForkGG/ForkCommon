﻿namespace ProjectAveryCommon.Model.Privileges.Entity.ReadEntity.ReadWorldsTab;

public class ReadWorldsTabPrivilege : IReadEntityPrivilege
{
    public string Name => "ReadWorldsTab";
    public string TranslationPath => "privileges.entity.read.worldsTab";
    public ulong EntityId { get; set; }

    public ReadWorldsTabPrivilege(ulong entityId)
    {
        EntityId = entityId;
    }
}