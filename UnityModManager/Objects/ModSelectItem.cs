using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityModManager.Objects
{
    internal class ModSelectItem
    {
        public required string Name { get; set; }
        public required string ItemPath { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
