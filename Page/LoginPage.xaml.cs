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
        // Generar un número de confirmación aleatorio
        int numeroConfirmacion = random.Next(100000, 999999); // Genera un número de 6 dígitos

        // Configurar de la cuenta de Gmail
        MailAddress addressFrom = new MailAddress("steam.multidaniel@protonmail.com", "gemoglobin2016");
        MailAddress addressTo = new MailAddress("ivanets.daniel@gmail.com");
        // Crear el mensaje de correo
        MailMessage message = new MailMessage(addressFrom, addressTo);
        message.Subject = "Asunto del correo";
        message.IsBodyHtml = true;

        // Construir el cuerpo del correo con el número de confirmación
        StringBuilder bodyBuilder = new StringBuilder();
        bodyBuilder.AppendLine("Este es el cuerpo del correo electrónico.");
        bodyBuilder.AppendLine($"Tu número de confirmación es: {numeroConfirmacion}");
        message.Body = bodyBuilder.ToString();
        
        //mensaje.To.Add("ivanets.daniel@gmail.com"); // Dirección de correo del destinatario
        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.Port = 587; // Puerto para Gmail
        client.EnableSsl = true; // Habilitar SSL
        client.UseDefaultCredentials = false; // No usar credenciales predeterminadas
        client.Credentials = new NetworkCredential("ivanets.daniel@gmail.com", "yztm mfxi klku mlkh");
        try
        {
            await client.SendMailAsync(message);
            await DisplayAlert("Éxito", "Correo electrónico enviado correctamente.", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Error al enviar el correo electrónico: " + ex.Message, "OK");
        }
    }

    private void clickValidarCorreo(object sender, EventArgs e)
    {

    }
}