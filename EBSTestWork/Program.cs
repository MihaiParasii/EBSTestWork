namespace EBSTestWork;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        INotification emailNotification = new EmailNotification();
        INotification smsNotification = new SMSNotification();
        var notificationService = new NotificationService();

        notificationService.SendNotification("This is an email notification", emailNotification);
        notificationService.SendNotification("This is an SMS notification", smsNotification);
    }


    private static void Ex4()
    {
        for (int i = 1; i <= 10; ++i)
        {
            Console.WriteLine(i);
        }
    }


    private static void Ex8()
    {
        int a = 4;
        int b = 0;

        try
        {
            int result = a / b;
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new DivideByZeroException();
        }
    }
}
