namespace DataBinding.DataCollection.Models
{
    public class User
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                }
            }
        }

        public User()
        {
            Name = string.Empty;
        }
    }
}
