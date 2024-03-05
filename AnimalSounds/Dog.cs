using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Dog : Animal
    {
        
            public string Breed { get; set; }

            public override void MakeSound()
            {
                Console.WriteLine("Dog barks: Woof woof!");
            }
        }

    }

