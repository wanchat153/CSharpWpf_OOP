using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWpf_OOP
{
    //Main class Animal
    //Interface
    internal class Animal
    {
        int sizeOfAnimal = 0;

        public int SizeOfAnimal { get => sizeOfAnimal; set => sizeOfAnimal = value; }

        public string breath()
        {
            return "I'm Ok";
        }
        public string move()
        {
            return "Go Go Go!";
        }
    }
}
