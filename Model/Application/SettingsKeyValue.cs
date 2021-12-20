using System.ComponentModel.DataAnnotations;

namespace ProjectAveryCommon.Model.Application;

public class SettingsKeyValue
{
    [Key]
    public string Key { get; set; }
    public string Value { get; set; }
}