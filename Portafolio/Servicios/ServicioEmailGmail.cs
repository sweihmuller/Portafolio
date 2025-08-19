using System.Net;
using System.Net.Mail;
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IServicioEmailGmail
    {
        Task Enviar(ContactoViewModel contacto);
    }

    public class ServicioEmailGmail : IServicioEmailGmail
    {
        private readonly IConfiguration _configuration;
        public ServicioEmailGmail(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var emailEmisor = _configuration.GetValue<string>("CONFIGURACIONES_EMAIL:EMAIL");
            var password = _configuration.GetValue<string>("CONFIGURACIONES_EMAIL:PASSWORD");
            var host = _configuration.GetValue<string>("CONFIGURACIONES_EMAIL:HOST");
            var puerto = _configuration.GetValue<int>("CONFIGURACIONES_EMAIL:PUERTO");

            var smtpCliente = new SmtpClient(host, puerto);
            smtpCliente.EnableSsl = true;
            smtpCliente.UseDefaultCredentials = false;

            smtpCliente.Credentials = new NetworkCredential(emailEmisor, password);
            var mensaje = new MailMessage(emailEmisor, emailEmisor, $"El cliente {contacto.nombre} ({contacto.email}) quiere contactarte", contacto.mensaje);

            await smtpCliente.SendMailAsync(mensaje);
        }
    }
}
