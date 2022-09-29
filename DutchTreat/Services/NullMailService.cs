using System.Drawing;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {
        private ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            //Log the message
            _logger.LogInformation($"To: {to}, Subject: {subject}, Body: {body}");

        }
    }
}
