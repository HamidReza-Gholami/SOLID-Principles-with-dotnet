namespace OpenClosedPrinciple_OCP_;
internal class BadDesing
{
    public class Report
    {
        public string Type
        {
            get;
            set;
        }

        public void GenerateReport()
        {
            switch (Type)
            {
                case "Pdf":
                    Console.WriteLine("Generating pdf report...");
                    break;
                case "Excel":
                    Console.WriteLine("Generating Excel report...");
                    break;
                default:
                    break;
            }
        }
    }
}
