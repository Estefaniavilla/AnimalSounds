using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

}

