using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAufgabe
{
    class Ape
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public CageType CageType { get; set; }

        public Ape (string type, string name, CageType cageType)
        {
            Type = type;
            Name = name;
            CageType = cageType;
        }

        override public string ToString()
        {
            return "Welches Tier " + Type + " - Name: " + Name + " - Käfigart " + CageType + "\n";
        }
    }
}
