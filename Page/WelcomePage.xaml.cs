namespace Iscapop.Page;

public partial class WelcomePage : Base.BasePage
{
	public WelcomePage()
	{
        InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginWithPasswordPage));
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}