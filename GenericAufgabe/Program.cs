using System;

namespace GenericAufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage<Ape> apeCage = new Cage<Ape>(CageType.ApeCage);
            Cage<Tiger> tigerCage = new Cage<Tiger>(CageType.TigerCage);
            Ape ape = GenericObj.GenerateObj<Ape>(new object[] { "Affe", "Chitta", CageType.ApeCage });
            apeCage.AddAnimal(ape);
            apeCage.RemoveAnimal(ape);
            Tiger tiger = GenericObj.GenerateObj<Tiger>(new object[] { "Tiger", "Rakesh", CageType.TigerCage });
            tigerCage.AddAnimal(tiger);
            Tiger tiger1 = GenericObj.GenerateObj<Tiger>(new object[] { "Tiger", "Paul", CageType.TigerCage });
            tigerCage.AddAnimal(tiger1);
            tigerCage.GetAnimals();
        }

       
    }
}
