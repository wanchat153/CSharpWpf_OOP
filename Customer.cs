using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpWpf_OOP
{
    internal class Customer
    {
        string name = "";
        string lastName = "";
        string address = "";
        string email = "";

        //Constructor class startup Method
        //Class name = Method name
        public Customer()
        {
            MessageBox.Show("Hello World");
        }
        public Customer(string name, string lastName)
        {
            MessageBox.Show("Hello " + name + " " + lastName);
        }

        //Edit>>Refactor>>Encapsulation (Ctrl+R+E)
        //Get Set to MainWindow.xaml.cs
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
