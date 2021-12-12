namespace ProjectAvery.Logic.Model.Enums;

public enum Privilege
{
    CreateEntity,
    DeleteEntity,
    RenameEntity,
    UpdateApplication,
    
    ReadAppSettingsGeneral,
    ReadAppSettingsDiscordBot,
    ReadAppSettingsTokens,
    ReadAppSettingsAdvanced,
    WriteAppSettingsGeneral,
    WriteAppSettingsDiscordBot,
    WriteAppSettingsTokens,
    WriteAppSettingsAdvanced,
    
    ReadConsoleTabConsole,
    ReadConsoleTabPlayerlist,
    ReadConsoleTabBanlist,
    ReadConsoleTabWhitelist,
    ReadSettingsTabGeneral,
    ReadSettingsTabVanillaProperties,
    ReadSettingsTabVersionSpecific,
    ReadWorldsTab,
    ReadPluginsTab,
    ReadModsTab, // WIP
    
    WriteConsoleTab,
    WriteSettingsTabGeneral,
    WriteSettingsTabVanillaProperties,
    WriteSettingsTabVersionSpecifics,
    WriteWorldsTab,
    WritePluginsTab,
    WriteModsTab, // WIP
}