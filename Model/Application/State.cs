using System.Collections.Generic;
using ProjectAveryCommon.Model.Entity.Pocos;

namespace ProjectAveryCommon.Model.Application
{
    /// <summary>
    ///     The class that is filled with all state data of the application to be passed to the frontend
    /// </summary>
    public class State
    {
        public List<IEntity> Entities { get; set; }
    }
}