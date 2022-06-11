using System.Collections.Generic;
using BrainWasherLibrary.Enums;

namespace BrainWasherLibrary.Models
{
    public class Combo
    {

        public IEnumerable<string> Entries { get; }
        public PentestingInput Input { get; }

        public Combo(IEnumerable<string> entries, PentestingInput input)
        {
            Entries = entries;
            Input = input;
        }
    }
}