using Entity;

namespace NotificationPattern
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person("", "");

            person.Validate();
            
            if (person.IsValid)
            {

            }
            else
            {
                foreach (var notification in person.Notifications)
                {
                    Console.WriteLine($"Error: {notification}");
                }
            }

        }
    }
}