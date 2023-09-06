using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWpf_OOP
{
    internal class Square : Shapes
    {
        int side = 0;

        public int Side { get => side; set => side = value; }

        //override Area from main Shapes
        public override int Area()
        {
            return side * side;
        }
    }
}
