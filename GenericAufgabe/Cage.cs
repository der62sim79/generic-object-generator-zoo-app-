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
        }
        public void GetAnimals()
        {
            foreach(var n in this.cageList)
            {
                Console.WriteLine(n.ToString());
            }
        }

        public void RemoveAnimal(T animal)
        {
            int index = cageList.IndexOf(animal);
            cageList.RemoveAt(index);
            Console.WriteLine(" => " + animal + " ist raus aus dem Käfig");
        }
    }
}
