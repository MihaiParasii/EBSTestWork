namespace EBSTestWork;

public class SMSNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Message from SMS: {message}");
    }
}
