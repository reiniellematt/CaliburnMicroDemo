using Caliburn.Micro;
using CMTestLibrary;
using System;
using System.Collections.Generic;

namespace WPFUI.ViewModels
{
    public class AViewModel : Screen
    {
        private List<Person> _people = new List<Person>();
        private Person _selectedPerson = new Person();

        public List<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                NotifyOfPropertyChange(() => People);
            }
        }
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => LastName);
            }
        }
        public string FirstName
        {
            get
            {
                return _selectedPerson.FirstName;
            }
        }
        public string LastName
        {
            get
            {
                return _selectedPerson.LastName;
            }
        }

        public AViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            People.Add(new Person { Id = 1, FirstName = "David", LastName = "Fisher" });
            People.Add(new Person { Id = 2, FirstName = "Susan", LastName = "Butler" });
            People.Add(new Person { Id = 3, FirstName = "Terry", LastName = "Hoffman" });
            People.Add(new Person { Id = 4, FirstName = "Anna", LastName = "Sims" });
            People.Add(new Person { Id = 5, FirstName = "Jeremy", LastName = "Armstrong" });
        }
    }
}
