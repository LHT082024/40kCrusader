using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _40kCrusader.model
{
    //this is the model for the actual armies stored in Json
    public class ArmyModel
    {
        public string? ArmyName { get; set; }
        public string? ArmyFaction { get; set; }
        public int ArmyPointTotal { get; set; }
        public int SupplyLimit { get; set; }
        public int BattleTally { get; set; }
        public int AllSquadsNumber { get; set; }
        public List<SquadModel> Squads { get; set; } = new();
        public int RequistionPoints { get; set; }
    }
}