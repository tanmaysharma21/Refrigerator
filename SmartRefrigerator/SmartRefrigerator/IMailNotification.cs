using System;
using System.Collections.Generic;
using System.Text;

/*namespace SmartRefrigerator
{
    interface IMailNotifier : INotifier
    {
        string Subject(string message);
    }

    
}*/

namespace Test
{
    public interface INotification
    {
        string Type { get; set; }
        string Message { get; set; }
    }

    public interface IEmailNotification : INotification
    {
        string Subject { get; set; }
    }

    public interface INotifier
    {
        void Notify(INotification notification);
    }

    public class Notifier : INotifier
    {
        public virtual void Notify(INotification notification)
        {
            
        }
    }

    /*public class NotifierFactory
    {
        public INotifier CreateNotifier(string notificationType)
        {
            switch (switch_on)
            {
                default:
            }
        }
    }*/

    public class EmailNotifier : Notifier
    {
        public override void Notify(INotification notification)
        {
            IEmailNotification emailNotification = notification as IEmailNotification;


        }
    }
}
