namespace SingleResponsibilityPrinciple_SRP_;
internal class GoodDesign
{
    public class User
    {
        public string Name { get; }
        public string Email { get; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class UserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("user is saving...");
        }
    }
    public class EmailService
    {
        public void sendEmail(User user, string message)
        {
            Console.WriteLine($"Sending emal to{user.Name} and the message is {message}");
        }
    }

    public class ReportGenerator
    {
        public void generateReport(User user)
        {
            Console.WriteLine($"generating report for {user.Name}");
        }
    }
}
