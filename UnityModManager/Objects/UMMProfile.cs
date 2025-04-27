using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityModManager.Objects
{
    internal class UMMProfile
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public string GamePath { get; set; }

        public string[] Mods { get; set; }

        public UMMProfile(string name, string id, string gamePath, string[] mods)
        {
            Name = name;
            Id = id;
            GamePath = gamePath;
            Mods = mods;
        }
    }
}
