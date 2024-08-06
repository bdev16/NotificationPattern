using Notification;

namespace Entity
{
    public class Person : Notifiable
    {
        public Person(string name, string emailAdress)
        {
            Name = name;
            EmailAdress = emailAdress;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string EmailAdress { get; private set; }

        public void Validate()
        {
            
            if (string.IsNullOrEmpty(Name))
                AddNotification("O Nome precisa ser informado!");
            
            if (string.IsNullOrEmpty(EmailAdress))
                AddNotification("O Email precisa ser informado!");
        }
    }
}