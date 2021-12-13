﻿namespace ProjectAveryCommon.Model.Privileges.Entity.WriteEntity.WriteSettingsTab;

public class WriteVersionSpecificSettingsTabPrivilege : IWriteSettingsTabPrivilege
{
    public string Name => "WriteSettingsTabVersionSpecific";
    public string TranslationPath => "privileges.entity.write.settingsTab.versionSpecific";
    public ulong EntityId { get; set; }

    public WriteVersionSpecificSettingsTabPrivilege(ulong entityId)
    {
        EntityId = entityId;
    }
}