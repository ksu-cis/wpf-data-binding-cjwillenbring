using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UniversityRegistry.Data;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {

        /// <summary>
        /// A proxy event handler
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged;

        public PersonList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A proxy event listener that passes on SelectionChanged events
        /// </summary>
        /// <param name="sender">The ListView that had its selection changed</param>
        /// <param name="e">The event arguments</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Adds a new person to the collection
        /// </summary>
        /// <param name="sender">The add person button</param>
        /// <param name="e"></param>
        private void OnAddPersonClick(object sender, EventArgs e)
        {
            if (DataContext is ObservableCollection<Person> people)
            {
                people.Add(new Person() { FirstName = "New", LastName = "Person", DateOfBirth = new DateTime(), Role = Role.UndergraduateStudent, Active = false });
            }
        }
    }
}
