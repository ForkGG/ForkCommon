using ForkCommon.Model.Entity.Pocos;
using ForkCommon.Model.Entity.Pocos.ServerSettings;

namespace ForkCommon.Model.Payloads.Entity;

public class CreateServerPayload
{
    public string ServerName { get; set; } = "Server";
    public ServerVersion ServerVersion { get; set; } = new ServerVersion();
    public VanillaSettings VanillaSettings { get; set; } = new VanillaSettings("world");
    public JavaSettings JavaSettings { get; set; } = new JavaSettings();
    public string WorldPath { get; set; } = null;
}