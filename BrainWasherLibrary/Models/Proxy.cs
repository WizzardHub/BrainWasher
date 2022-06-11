using System.Collections.Generic;
using BrainWasherLibrary.Enums;

namespace BrainWasherLibrary.Models
{
    public class Proxy
    {
        
        public IEnumerable<string> Entries { get; }
        public ProxyProtocol Protocol { get; }

    }
}