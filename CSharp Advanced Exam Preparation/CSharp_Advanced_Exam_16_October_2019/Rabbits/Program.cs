using System;

namespace Rabbits
{
    public class StartUp
    {
        static void Main()
        {
            //Initialize  the repository
            Cage cage = new Cage("Wildness", 20);
            //Initialize entity
            Rabbit rabit = new Rabbit("Fluffy", "Blanc te Hotot");
            //Print Rabbit
            Console.WriteLine(rabit);//Rabit (Blanc te Hotot): Fluffy

            //Add Rabbit
            cage.Add(rabit);
            Console.WriteLine(cage.Count);//1
            //Remove Rabbit
            cage.RemoveRabbit("Rabit Name"); //false

            Rabbit secondRabbit = new Rabbit("Bunny", "Brazilian");
            Rabbit thirdRabbit = new Rabbit("Jumpy", "Cashmere Lop");
            Rabbit fourthRabbit = new Rabbit("Puffy", "Cashmere Lop");
            Rabbit fifthRabbit = new Rabbit("Marlin", "Brazilian");

            //Add Rabbits
            cage.Add(secondRabbit);
            cage.Add(thirdRabbit);
            cage.Add(fourthRabbit);
            cage.Add(fifthRabbit);
        }
    }
}
