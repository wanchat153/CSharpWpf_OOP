using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpWpf_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Customer customer = new Customer();
            //customer.Name = "Wanchat";
            //customer.LastName = "Saenjaingam";
            //MessageBox.Show(customer.Name+customer.LastName);

            //Cat cat = new Cat();
            //MessageBox.Show(cat.cry());
            //Inheritance Cat from Animal
            //MessageBox.Show(cat.breath());

            //override from cat
            //MessageBox.Show(cat.move());

            ////Instance = square, square2
            //Square square = new Square();
            //Square square2 = new Square();
            //square.Side = 5;
            //square2.Side = 10;
            //MessageBox.Show(square.Area().ToString());
            //MessageBox.Show(square2.Area().ToString());

            //sayHello();
            //sayHello("Wanchat");

        }

        ////Overload sayHello
        //private void sayHello()
        //{
        //    MessageBox.Show("Hello World");
        //}
        //private void sayHello(string name)
        //{
        //    MessageBox.Show("Hello " + name);
        //}

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer("Wanchat","Saenjaingam");
        }
    }
}
