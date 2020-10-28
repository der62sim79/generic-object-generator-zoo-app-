using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAufgabe
{
    class Tiger
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public CageType CageType { get; set; }

        public Tiger(string type, string name, CageType cageType)
        {
            Type = type;
            Name = name;
            CageType = cageType;
        }
    }
}
