using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace zooMA
{
    
public class Program {
    
    public class Animal{}
    public class Mammal : Animal{}
    public class Bear : Mammal{}
    public class Donkey : Mammal{}
    public class Lion : Mammal{}
    public class Fish : Animal{}
    public class Salmon : Fish{}
    public class Clownfish : Fish{}
    public class Student{}

    static void Main() {
        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Fish()); // OKAY
            fishZoo.AddAnimal(new Clownfish()); // OKAY
        }
        
        {
            Zoo<Animal> animalZoo = new Zoo<Animal>();
            animalZoo.AddAnimal(new Fish()); // OKAY
            animalZoo.AddAnimal(new Clownfish()); // OKAY
            animalZoo.AddAnimal(new Lion()); // OKAY
            animalZoo.AddAnimal(new Donkey()); // OKAY
        }
        
        {
            Zoo<Lion> lionZoo = new Zoo<Lion>();
            lionZoo.AddAnimal(new Lion()); // OKAY
            lionZoo.AddAnimal(new Lion()); // OKAY
            lionZoo.AddAnimal(new Lion()); // OKAY
        }
        

        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Salmon());
            fishZoo.AddAnimal(new Salmon());
            Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
        }
    }

    class Zoo<TAnimal> where TAnimal : Animal {
        List<TAnimal> animals = new List<TAnimal>();

        public void AddAnimal(TAnimal animal) {
            this.animals.Add(animal);
        }

        public bool HasAnimal<TSpecies>() where TSpecies : TAnimal {
            for (int i = 0; i < this.animals.Count; i++){
                if (this.animals[i] is TSpecies){ 
                    return true;
                    
                }
            }
            return false;
        }
    }
}