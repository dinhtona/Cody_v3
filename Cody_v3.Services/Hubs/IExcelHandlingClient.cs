namespace ExcelWebTool.Services.Hubs
{
    public interface IExcelHandlingClient
    {
        Task ReceiveMessage(string message, double percent);
    }
}
