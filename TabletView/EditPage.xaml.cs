namespace TabletView;

public partial class EditPage : ContentPage
{
	public EditPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AccountDetail)}");
    }
}
