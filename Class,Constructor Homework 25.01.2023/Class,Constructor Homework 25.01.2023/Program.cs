using Class_Constructor_Homework_25._01._2023;
using System;

namespace Class_Constructor_Homework_25._01._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.name = "Rex";
            animal1.breed = "Belgian Malinois";
            animal1.color = "Brown";
            animal1.age = 4;

            Console.WriteLine(animal1.GetDetails());
            Building building1 = new Building("Park Dede Qorqud", 24, 48);
            building1.GetVolume();
        }
    }
}