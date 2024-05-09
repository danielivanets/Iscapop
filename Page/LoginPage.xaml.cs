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
        // Generar un número de confirmación aleatorio
        numeroConfirmacion = random.Next(100000, 999999); // Genera un número de 6 dígitos

        // Configurar de la cuenta de Gmail
        MailAddress addressFrom = new MailAddress("ccorreosdeprueba@gmail.com", "ccorreosdeprueba@gmail.com");
        correo = txtCorreo.Text;
        MailAddress addressTo = new MailAddress(correo); //steam.multidaniel@protonmail.com
        // Crear el mensaje de correo
        MailMessage message = new MailMessage(addressFrom, addressTo);
        message.Subject = "Número de confirmación --- "+ numeroConfirmacion;
        message.IsBodyHtml = true;

        // Construir el cuerpo del correo con el número de confirmación
        StringBuilder bodyBuilder = new StringBuilder();
        bodyBuilder.AppendLine($"Tu número de confirmación es: {numeroConfirmacion}");
        message.Body = bodyBuilder.ToString();
        
        //mensaje.To.Add("ivanets.daniel@gmail.com"); // Dirección de correo del destinatario
        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.Port = 587; // Puerto para Gmail
        client.EnableSsl = true; // Habilitar SSL
        client.UseDefaultCredentials = false; // No usar credenciales predeterminadas
        client.Credentials = new NetworkCredential("ccorreosdeprueba@gmail.com", "retp xoow ecvl hhej");
        try
        {
            txtCodigo.Text = numeroConfirmacion.ToString();
            await client.SendMailAsync(message);
            await DisplayAlert("Éxito", "Correo electrónico enviado correctamente. ("+numeroConfirmacion+")", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Error al enviar el correo electrónico: " + ex.Message, "OK");
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
            await DisplayAlert("Error", "Código incorrecto", "OK");
        }
        
    }

}