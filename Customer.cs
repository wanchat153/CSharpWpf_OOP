﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWpf_OOP
{
    internal class Customer
    {
        string name = "";
        string lastName = "";
        string address = "";
        string email = "";

        //Edit>>Refactor>>Encapsulation (Ctrl+R+E)
        //Get Set to MainWindow.xaml.cs
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
