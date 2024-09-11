namespace EBSTestWork;

public class NotificationService
{
    public void SendNotification(string message, INotification notification) {
        notification.Notify(message);
    }
}
