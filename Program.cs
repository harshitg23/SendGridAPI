using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("harshitgoyakl923@gmail.com","Brent");
            var to = new EmailAddress("harshitgoyal24041999@gmail.com","Brent");
            var subject = "Hello Harshit How are You!";
            var PlainTextCoontent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#!</strong>";
            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                subject,
                PlainTextCoontent,
                htmlContent
            );

            var response = await client.SendEmailAsync(msg);

        }
    }
}
