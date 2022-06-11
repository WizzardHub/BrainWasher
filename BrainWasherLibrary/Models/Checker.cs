using System.Collections.Generic;
using BrainWasherLibrary.Enums;

namespace BrainWasherLibrary.Models
{
    public class Checker
    {
        
        public List<Combo> Combos { get; }
        public List<Proxy> Proxy { get; }
        public CheckerStatus Status { get; }
        
    }
}