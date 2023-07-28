namespace DependencyInversionPrinciple_DIP_
{
    internal class GoodDesing
    {
        // High level module
        // Abstraction
        public interface IEmailSender
        {
            void Send(string email, string content);
        }

        // Low level module
        public class EmailSender : IEmailSender
        {
            public void Send(string email, string content) => Console.WriteLine($"Sending email to {email}");
        }

        public class OrderService
        {
            private readonly IEmailSender _emailSender;

            public OrderService(IEmailSender emailSender)
            {
                _emailSender = emailSender;
            }

            public void CreateOrder()
            {
                Console.WriteLine("Creating order");

                _emailSender.Send("example@gmail.com", "hey this email sent from good desing.");
            }
        }
    }
}
