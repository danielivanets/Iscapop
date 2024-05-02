using System.Net.Mail;
using System.Net;
using System;
using System.Text;
using Iscapop.ViewModel;

namespace Iscapop.Page;

public partial class LoginPage : Base.BasePage
{
    private Random random = new Random();
    

    public LoginPage()
	{
		InitializeComponent();
		
	}

    private async void clickEnviarCodigo(object sender, EventArgs e)
    {
        // Generar un n�mero de confirmaci�n aleatorio
        int numeroConfirmacion = random.Next(100000, 999999); // Genera un n�mero de 6 d�gitos

        // Configurar de la cuenta de Gmail
        MailAddress addressFrom = new MailAddress("steam.multidaniel@protonmail.com", "gemoglobin2016");
        MailAddress addressTo = new MailAddress("ivanets.daniel@gmail.com");
        // Crear el mensaje de correo
        MailMessage message = new MailMessage(addressFrom, addressTo);
        message.Subject = "Asunto del correo";
        message.IsBodyHtml = true;

        // Construir el cuerpo del correo con el n�mero de confirmaci�n
        StringBuilder bodyBuilder = new StringBuilder();
        bodyBuilder.AppendLine("Este es el cuerpo del correo electr�nico.");
        bodyBuilder.AppendLine($"Tu n�mero de confirmaci�n es: {numeroConfirmacion}");
        message.Body = bodyBuilder.ToString();
        
        //mensaje.To.Add("ivanets.daniel@gmail.com"); // Direcci�n de correo del destinatario
        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.Port = 587; // Puerto para Gmail
        client.EnableSsl = true; // Habilitar SSL
        client.UseDefaultCredentials = false; // No usar credenciales predeterminadas
        client.Credentials = new NetworkCredential("ivanets.daniel@gmail.com", "yztm mfxi klku mlkh");
        try
        {
            await client.SendMailAsync(message);
            await DisplayAlert("�xito", "Correo electr�nico enviado correctamente.", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Error al enviar el correo electr�nico: " + ex.Message, "OK");
        }
    }

    private void clickValidarCorreo(object sender, EventArgs e)
    {

    }
}