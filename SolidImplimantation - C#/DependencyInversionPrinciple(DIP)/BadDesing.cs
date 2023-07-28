namespace DependencyInversionPrinciple_DIP_
{
    internal class BadDesing
    {
        // Low level module
        public class EmailSender
        {
            public void Send(string email, string content)
            {
                Console.WriteLine($"Sending email to {email}");
            }
        }

        // High level module
        public class OrderService
        {
            private readonly EmailSender _emailSender;

            public OrderService(EmailSender emailSender)
            {
                _emailSender = emailSender;
            }

            public void CreateOrder()
            {
                Console.WriteLine("Creating order");
                
                _emailSender.Send("example@gmail.com", "hey this email sent from bad desing.");
            }
        }
    }
}
