namespace TabletView;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Routing.RegisterRoute(nameof(MenuPage),
        //       typeof(MenuPage));

        Routing.RegisterRoute(nameof(EditPage),
              typeof(EditPage));

        Routing.RegisterRoute(nameof(AccountDetail),
               typeof(AccountDetail));

        Routing.RegisterRoute(nameof(AccountPage),
               typeof(AccountPage));
       
    }
}

