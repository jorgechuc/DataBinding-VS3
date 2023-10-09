namespace DataBinding.XAMLElement;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		TextLabel.Text = TextEntry.Text;
    }
}

