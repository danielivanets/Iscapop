namespace Iscapop.Page;

public partial class LoginWithPasswordPage : Base.BasePage
{
	public LoginWithPasswordPage()
	{
		InitializeComponent();
	}

    private async void LoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MenuPage));
    }
}