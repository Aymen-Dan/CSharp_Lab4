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
            var personList = new PersonListViewModel();
            DataContext = personList;
            Show();
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
