using CSharp_Lab2_ParsonApp;
using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace CSharp_Lab4
{
    public class PersonListViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Person> _people;
        /* internal ObservableCollection<Person> People
         {
             get { return _people; }
             set
             {
                 _people = value; // Initialize the backing field with the provided value
                 OnPropertyChanged(nameof(People)); // Notify property changed
             }
         }*/
        private ICollectionView _collectionView;

        public ICollectionView CollectionView
        {
            get => _collectionView;
            set
            {
                _collectionView = value;
                OnPropertyChanged(nameof(CollectionView));
            }
        }

        //public ICollectionView CollectionView { get; private set; }

        public PersonListViewModel()
        {
            //Initialize People collection
            _people = new ObservableCollection<Person>();

            GenerateUsers();
            CollectionView = CollectionViewSource.GetDefaultView(_people);

            // Inside PersonListViewModel constructor after CollectionView initialization
            CollectionView.SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));
            CollectionView.SortDescriptions.Add(new SortDescription("LastName", ListSortDirection.Ascending));
            CollectionView.SortDescriptions.Add(new SortDescription("Email", ListSortDirection.Ascending));
            CollectionView.SortDescriptions.Add(new SortDescription("DateOfBirth", ListSortDirection.Ascending));
            // CollectionView.SortDescriptions.Add(new SortDescription("IsAdult", ListSortDirection.Ascending));
            CollectionView.SortDescriptions.Add(new SortDescription("SunSign", ListSortDirection.Ascending));
            CollectionView.SortDescriptions.Add(new SortDescription("ChineseSign", ListSortDirection.Ascending));
            // CollectionView.SortDescriptions.Add(new SortDescription("IsBirthday", ListSortDirection.Ascending));

        }

        private void GenerateUsers()
        {
            for (int i = 0; i < 50; i++)
            {
                var random = new Random();
                var dateOfBirth = DateTime.Now.AddYears(-random.Next(18, 70));
                var person = new Person($"FirstName{i}", $"LastName{i}", $"email{i}@example.com", dateOfBirth);

                if (_people != null)
                {
                    _people.Add(person);
                }
                else
                {
                    throw new Exception("Oh no! Peoples are null!");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
