using System.Net.Mail;
using System.Net;
using System.Text;
using Iscapop.ViewModel;
using Iscapop.Model;

namespace Iscapop.Page;

public partial class LoginPage : Base.BasePage
{
    private Random random = new Random();
    private int numeroConfirmacion;
    private string correo;
    private string codigo;
    public string codOrganismo;
    private LoginPageVM vm;

    public LoginPage()
	{
		InitializeComponent();
        BindingContext = vm = new LoginPageVM();
    }

    private async void clickEnviarCodigo(object sender, EventArgs e)
    {
        // Generar un n�mero de confirmaci�n aleatorio
        numeroConfirmacion = random.Next(100000, 999999); // Genera un n�mero de 6 d�gitos

        // Configurar de la cuenta de Gmail
        MailAddress addressFrom = new MailAddress("ccorreosdeprueba@gmail.com", "ccorreosdeprueba@gmail.com");
        correo = txtCorreo.Text;
        MailAddress addressTo = new MailAddress(correo); //steam.multidaniel@protonmail.com
        // Crear el mensaje de correo
        MailMessage message = new MailMessage(addressFrom, addressTo);
        message.Subject = "N�mero de confirmaci�n --- "+ numeroConfirmacion;
        message.IsBodyHtml = true;

        // Construir el cuerpo del correo con el n�mero de confirmaci�n
        StringBuilder bodyBuilder = new StringBuilder();
        bodyBuilder.AppendLine($"Tu n�mero de confirmaci�n es: {numeroConfirmacion}");
        message.Body = bodyBuilder.ToString();
        
        //mensaje.To.Add("ivanets.daniel@gmail.com"); // Direcci�n de correo del destinatario
        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.Port = 587; // Puerto para Gmail
        client.EnableSsl = true; // Habilitar SSL
        client.UseDefaultCredentials = false; // No usar credenciales predeterminadas
        client.Credentials = new NetworkCredential("ccorreosdeprueba@gmail.com", "retp xoow ecvl hhej");
        try
        {
            txtCodigo.Text = numeroConfirmacion.ToString();
            await client.SendMailAsync(message);
            await DisplayAlert("�xito", "Correo electr�nico enviado correctamente. ("+numeroConfirmacion+")", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Error al enviar el correo electr�nico: " + ex.Message, "OK");
        }
    }

    private async void clickValidarCorreo(object sender, EventArgs e)
    {
        correo = txtCorreo.Text;
        codigo = txtCodigo.Text;
        if (int.Parse(txtCodigo.Text) == numeroConfirmacion)
        {
            Organismo Organismo = new Organismo();
            Organismo.Codigo = numeroConfirmacion;
            Organismo.Email = correo;
            Organismo.Nom = "NombreORGanismo";
            await Shell.Current.GoToAsync($"{nameof(LoginConfirmPasswordPage)}",
             new Dictionary<string, object>
             {
                 { "Organismo", Organismo }
             }
            );
            
        }
        else
        {
            await DisplayAlert("Error", "C�digo incorrecto", "OK");
        }
        
    }

}