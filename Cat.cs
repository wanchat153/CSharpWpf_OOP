using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWpf_OOP
{
    //Inheritance Cat from main Animal
    internal class Cat : Animal
    {
        string name;

        public string Name { get => name; set => name = value; }

        public string cry()
        {
            return "Meaowww!";
        }

        //override move from main Animal
        public string move()
        {
            return "Super Runn!";
        }
    }
}
