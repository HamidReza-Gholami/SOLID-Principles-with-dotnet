namespace OpenClosedPrinciple_OCP_;
internal class GoodDesing
{
    public interface IReportBase
    {
        public void GenerateReport();
    }

    public class PdfReport : IReportBase
    {
        public void GenerateReport() => Console.WriteLine("Generating PDF Report....");
    }

    public class ExcelReport : IReportBase
    {
        public void GenerateReport() => Console.WriteLine("Generating Excel Report....");
    }

}
