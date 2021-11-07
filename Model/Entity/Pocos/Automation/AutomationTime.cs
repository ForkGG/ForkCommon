using ProjectAveryCommon.Model.Entity.Enums;

namespace ProjectAveryCommon.Model.Entity.Pocos.Automation
{
    /// <summary>
    /// A class for all automations
    /// </summary>
    public class AutomationTime
    {
        public ulong Id { get; set; }
        public bool Enabled { get; set; }
        public AutomationType Type { get; set; }
        public virtual SimpleTime Time { get; set; } 
        
        public ulong ServerId { get; set; }
        public virtual Server Server { get; set; }
    }
}