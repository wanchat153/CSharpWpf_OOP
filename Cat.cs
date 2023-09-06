using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWpf_OOP
{
    //Inheritance Cat from main Animal
    //Cat "implements" the Animal interface
    internal class Cat : Animal
    {
        string name;

        public string Name { get => name; set => name = value; }

        public string cry()
        {
            return "Meaowww!";
        }

        //override move from main Animal
        //Polymorphism Inheritance Method != Method
        public string move()
        {
            return "Super Runn!";
        }
    }
}
