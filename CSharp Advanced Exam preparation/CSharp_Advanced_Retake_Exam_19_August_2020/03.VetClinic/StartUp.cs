using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Pet pet = new Pet("Gogi", 3, "Boki");
            //Console.WriteLine(pet);

            //Clinic clinic = new Clinic(3);
            //clinic.Add(pet);
            //Console.WriteLine(clinic.GetStatistics());
            //clinic.Add(new Pet("2", 3, "4"));
            //Console.WriteLine(clinic.GetStatistics());
            //Console.WriteLine(clinic.GetOldestPet());
            //Console.WriteLine(clinic.GetPet("Gogi", "Boki"));
            //Console.WriteLine(clinic.GetPet("Gogi", "Boki2"));
            //Console.WriteLine(clinic.Count);
            //Console.WriteLine(clinic.Remove("Gogi"));
            //Console.WriteLine(clinic.Remove("Gogi"));
            //Console.WriteLine(clinic.Remove("Gogi"));
            //Console.WriteLine(clinic.Count);
            //Console.WriteLine(clinic.GetStatistics());
            //clinic.Add(new Pet("2", 3, "4"));
            //clinic.Add(new Pet("2", 3, "4"));
            //clinic.Add(new Pet("2", 3, "4"));
            //clinic.Add(new Pet("2", 3, "4"));
            //clinic.Add(new Pet("2", 3, "4"));
            //Console.WriteLine(clinic .Count);

            //Clinic clinic2 = new Clinic(100);
            //Console.WriteLine(clinic2 .Count );
            //Console.WriteLine(clinic2 .Remove("1"));
            //Console.WriteLine(clinic2 .GetPet("213","123"));
            //Console.WriteLine(clinic2 .GetOldestPet());
            //Console.WriteLine(clinic2 .GetStatistics());

            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");

            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)

            // Add Pet
            clinic.Add(dog);

            // Remove Pet
            Console.WriteLine(clinic.Remove("Ellias")); // True
            Console.WriteLine(clinic.Remove("Pufa")); // False

            Pet cat = new Pet("Bella", 2, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");

            clinic.Add(cat);
            clinic.Add(bunny);

            // Get Oldest Pet
            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Zak 4 (Jon)

            // Get Pet
            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 2 (Mia)

            // Count
            Console.WriteLine(clinic.Count); // 2

            // Get Statistics
            Console.WriteLine(clinic.GetStatistics());
            //The clinic has the following patients:
            //Bella Mia
            //Zak Jon

        }
    }
}