using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _40kCrusader.model
{
    public class SquadModel
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int PointCost { get; set; }
        public int Experience { get; set; }
        public string? Rank { get; set; }
        public int CrusaderPoints { get; set; }
        public string? Model1 { get; set; }
        public string? Model2 { get; set; }
        public string? Model3 { get; set; }
        public string? Model4 { get; set; }
        public string? Wargear1 { get; set; }
    }
}