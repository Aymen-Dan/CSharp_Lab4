using CSharp_Lab2_ParsonApp;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharp_Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //Set up ViewModel and bind it to the View
            var viewModel = new PersonViewModel();
            DataContext = viewModel;
            Show();
        }

        private void SeePersonList_Click(object sender, RoutedEventArgs e)
        {
            var personListWindow = new PersonListWindow();
            personListWindow.Show();
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            var addPersonWindow = new AddPersonWindow();
            addPersonWindow.Show();
        }
    }
}