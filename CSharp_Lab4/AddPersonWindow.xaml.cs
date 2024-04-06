using CSharp_Lab2_ParsonApp;
using System.Windows;

namespace CSharp_Lab4
{
    public partial class AddPersonWindow : Window
    {
        public AddPersonWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
