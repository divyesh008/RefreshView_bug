namespace TabletView;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(EditPage)}");
    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AccountPage)}");
    }
}
