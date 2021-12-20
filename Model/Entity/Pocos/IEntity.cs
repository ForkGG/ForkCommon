using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectAveryCommon.Model.Entity.Enums;
using ProjectAveryCommon.Model.Entity.Transient.Console;

namespace ProjectAveryCommon.Model.Entity.Pocos
{
    public interface IEntity
    {
        // Database fields
        ulong Id { get; set; }
        bool Initialized { get; set; }
        JavaSettings JavaSettings { get; set; }
        ServerVersion Version { get; set; }
        string Name { get; set; }
        bool StartWithFork { get; set; }
        int ServerIconId { get; set; }
        
        // Unmapped fields
        List<ConsoleMessage> ConsoleMessages { get; }
        EntityStatus Status { get; set; }
        Action<string> ConsoleHandler { get; set; }  


        string ToString();
    }
}