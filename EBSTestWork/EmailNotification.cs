
namespace EBSTestWork;

public class EmailNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine("Sent from email service: " + message);
    }
}
