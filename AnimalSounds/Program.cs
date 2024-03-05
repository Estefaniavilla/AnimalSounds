using AnimalSounds;

class Program
{
    static void Main()
    {
       
        var myDog = new Dog
        {
            Name = "Buddy",
            Age = 3,
            Breed = "Golden Retriever"
        };

        
        Console.WriteLine($"Name: {myDog.Name}, Age: {myDog.Age}");

        
        myDog.MakeSound();
    }
}
