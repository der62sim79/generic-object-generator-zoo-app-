using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAufgabe
{
    class Cage<T>
    {
        List<T> cageList = new List<T>();
        public CageType Type { get; set; }

        public Cage(CageType type)
        {
            Type = type;
        }

        public void AddAnimal(T animal)
        {
            cageList.Add(animal);
            Console.WriteLine(" => " + animal + " ist im Käfig");
        }

        public void RemoveAnimal(T animal)
        {
            int index = cageList.IndexOf(animal);
            cageList.RemoveAt(index);
            Console.WriteLine(" => " + animal + " ist raus aus dem Käfig");
        }
    }
}
