using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Common
{
    public class EmailSender : IEmailSender
    {
        private readonly SendGridClient _client;
        private readonly EmailAddress _from;
        private const string plainTextContent = "idk what this was suppose to be.";

        public EmailSender(string apiKey)
        {
            _client = new SendGridClient(apiKey ?? throw new ArgumentNullException(nameof(apiKey)));
            _from = new EmailAddress("gardenmarket@gmail.com", "Garden Market");
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var toUser = new EmailAddress(email, "User");
            var msg = MailHelper.CreateSingleEmail(_from, toUser, subject, plainTextContent, htmlMessage);
            await _client.SendEmailAsync(msg).ConfigureAwait(false);
        }
    }
}
