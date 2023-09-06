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

            Square square = new Square();
            square.Side = 5;
            MessageBox.Show(square.Area().ToString());

        }
    }
}
