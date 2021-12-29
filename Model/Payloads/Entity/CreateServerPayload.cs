using ForkCommon.Model.Entity.Pocos;
using ForkCommon.Model.Entity.Pocos.ServerSettings;

namespace ForkCommon.Model.Payloads.Entity;

public class CreateServerPayload
{
    public string ServerName { get; set; } = "Server";
    public ServerVersion ServerVersion { get; set; }
    public VanillaSettings VanillaSettings { get; set; }
    public JavaSettings JavaSettings { get; set; }
    public string WorldPath { get; set; } = null;
}