using CSharp_Lab2_ParsonApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharp_Lab4
{
    public partial class PersonListWindow : Window
    {
        public PersonListWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
