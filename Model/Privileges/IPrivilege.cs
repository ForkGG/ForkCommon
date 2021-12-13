using System.ComponentModel;

namespace ProjectAveryCommon.Model.Privileges;

[Description("Any privilege")]
public interface IPrivilege
{
    public string Name { get; }
    public string TranslationPath { get; }
}