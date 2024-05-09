using Iscapop.Page;

namespace Iscapop
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Page.WelcomePage), typeof(Page.WelcomePage));
            Routing.RegisterRoute(nameof(Page.LoginPage), typeof(Page.LoginPage));
            Routing.RegisterRoute(nameof(Page.LoginConfirmPasswordPage), typeof(Page.LoginConfirmPasswordPage));
            Routing.RegisterRoute(nameof(Page.LoginWithPasswordPage), typeof(Page.LoginWithPasswordPage));
            Routing.RegisterRoute(nameof(Page.MenuPage), typeof(Page.MenuPage));


        }
    }
}
