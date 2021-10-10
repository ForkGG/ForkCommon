using System.Collections.Generic;

namespace ProjectAveryCommon.Model.Entity.Pocos.ServerSettings
{
    public abstract class AbstractSettings
    {
        public Dictionary<string, string> SettingsDictionary { get; protected set; }
    }
}