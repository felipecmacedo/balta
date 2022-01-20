using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            var Id = Guid.NewGuid(); //SPOF
        }
        public Guid Id { get; set; }
    }
}