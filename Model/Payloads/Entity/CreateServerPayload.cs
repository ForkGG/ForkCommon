using ProjectAveryCommon.Model.Entity.Pocos;
using ProjectAveryCommon.Model.Entity.Pocos.ServerSettings;

namespace ProjectAveryCommon.Model.Payloads.Entity;

public class CreateServerPayload
{
    public string ServerName { get; set; } = "Server";
    public ServerVersion ServerVersion { get; set; }
    public VanillaSettings VanillaSettings { get; set; }
    public JavaSettings JavaSettings { get; set; }
    public string WorldPath { get; set; } = null;
}