using Iscapop.Model;
using Iscapop.ViewModel;

namespace Iscapop.Page;

[QueryProperty(nameof(Organismo), "Organismo")]
public partial class LoginConfirmPasswordPage : Base.BasePage
{

	private LoginConfirmPasswordVM vm;
	private Organismo _organismo;
	public Organismo Organismo
	{
        get { return _organismo; }
        set { SetProperty(ref _organismo, value); vm.AssignData(Organismo); }
    }

    public LoginConfirmPasswordPage()
    {
        InitializeComponent();
        BindingContext = vm = new LoginConfirmPasswordVM();
        vm.AssignData(Organismo);
    }

    private async void ContinueClicked(object sender, EventArgs e)
    {
        // Verificar si las contraseñas coinciden
        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            await DisplayAlert("Error", "Las contraseñas no coinciden", "OK");
            return;
        }

            
        Organismo.Password = txtPassword.Text;
        Organismo.Momento = DateTime.Now;
        vm.InsertOrganismo();
        await Shell.Current.GoToAsync($"{nameof(LoginWithPasswordPage)}");
    }
}