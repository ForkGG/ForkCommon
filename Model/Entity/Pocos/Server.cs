﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using ProjectAveryCommon.Model.Entity.Enums;
using ProjectAveryCommon.Model.Entity.Pocos.Automation;
using ProjectAveryCommon.Model.Entity.Pocos.Player;
using ProjectAveryCommon.Model.Entity.Pocos.ServerSettings;
using ProjectAveryCommon.Model.Entity.Transient.Console;

namespace ProjectAveryCommon.Model.Entity.Pocos
{
    public class Server : IEntity
    {
        public Server(string name, ServerVersion version, VanillaSettings vanillaSettings, JavaSettings javaSettings)
        {
            Name = name;
            Version = version;
            JavaSettings = javaSettings;
            VanillaSettings = vanillaSettings;
            AutomationTimes = new List<AutomationTime>(8);
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(0, 0), Type = AutomationType.Restart });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(6, 0), Type = AutomationType.Restart });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(12, 0), Type = AutomationType.Restart });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(18, 0), Type = AutomationType.Restart });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(0, 0), Type = AutomationType.Stop });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(12, 0), Type = AutomationType.Stop });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(0, 0), Type = AutomationType.Start });
            AutomationTimes.Add(new AutomationTime
                { Enabled = false, Time = new SimpleTime(12, 0), Type = AutomationType.Start });
        }

        /// <summary>
        ///     Constructor for deserializer/ef core
        ///     This is called, because the default constructor does contain unmapped values
        /// </summary>
        public Server()
        {
            // We need to load the server settings here
            //TODO CKE
        }

        public bool AutoSetSha1 { get; set; } = true;
        public DateTime ResourcePackHashAge { get; set; } = DateTime.MinValue;

        public List<AutomationTime> AutomationTimes { get; set; }
        
        public List<ServerPlayer> ServerPlayers { get; set; }

        [NotMapped] [JsonIgnore] public VanillaSettings VanillaSettings { get; set; }

        [NotMapped] [JsonIgnore] public string FullName => Name + " (" + Version.Version + ")";

        [NotMapped] [JsonIgnore] public string JarLink => Version.JarLink;

        public ulong Id { get; set; }
        public string Name { get; set; }
        public ServerVersion Version { get; set; }
        public JavaSettings JavaSettings { get; set; }

        public bool Initialized { get; set; } = false;
        public bool StartWithFork { get; set; } = false;
        public int ServerIconId { get; set; }

        [NotMapped][JsonIgnore] public List<ConsoleMessage> ConsoleMessages { get; } = new ();
        [NotMapped] public EntityStatus Status { get; set; } = EntityStatus.Stopped;
        [NotMapped][JsonIgnore] public Action<string> ConsoleHandler { get; set; } 

        public override string ToString()
        {
            string name = Name;
            if (Name.Length > 10) name = name.Substring(0, 10);
            return name + " (" + Version.Version + ")";
        }
    }
}