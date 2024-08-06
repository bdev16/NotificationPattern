namespace Notification
{
    public abstract class Notifiable
    {
        private readonly List<string> _notifications = new List<string>();

        public IReadOnlyCollection<string> Notifications => _notifications;

        public void AddNotification(string message)
        {
            _notifications.Add(message);
        }

        public bool IsValid => _notifications.Count == 0;
    }
}