namespace SingleResponsibilityPrinciple_SRP_;
public class BadDesign
{
   // Bad Design
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }

        public void SaveUser()
        {
            Console.WriteLine("Saving User...");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating Report....");
        }
    }

}
