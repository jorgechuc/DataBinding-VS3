using DataBinding.DataCollection.Models;
using System.Collections.ObjectModel;

namespace DataBinding.DataCollection
{
    public partial class MainPage : ContentPage
    {
        private string _name;
        private ObservableCollection<User> _users;

        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            _users = new ObservableCollection<User>();
            LoadUsers();

            NameEntry.BindingContext = this;
            UsersCollectionView.BindingContext = _users;
        }

        private void LoadUsers()
        {
            _users.Add(new User { Name = "Peter Parker" });
            _users.Add(new User { Name = "Tony Stark" });
            _users.Add(new User { Name = "Natasha Romanoff" });
        }

        private void AddUser(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                _users.Add(new User { Name = name });
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            AddUser(Name);
            Name = string.Empty;
        }
    }
}