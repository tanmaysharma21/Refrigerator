using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public interface INotifier
    {
        void Notify();
    }

    /*public abstract class Notifier : INotifier
    {
        public virtual void Notify(INotification notification)
        {

        }
    }*/

    public class TextNotifier : INotifier
    {
        Vegetable vegetable;
        int quantity;

        public TextNotifier(Vegetable vegetable, int quantity)
        {
            this.vegetable = vegetable;
            this.quantity = quantity;
        }

        public void Notify()
        {
            INotification notification = new TextNotification(vegetable, quantity);
            string message = notification.Message;
        }
    }

    public class EmailNotifier : INotifier
    {
        Vegetable vegetable;
        int quantity;

        public EmailNotifier(Vegetable vegetable, int quantity)
        {
            this.vegetable = vegetable;
            this.quantity = quantity;
        }
        public void Notify()
        {
            IEmailNotification emailNotification = new EmailNotification(vegetable, quantity);
            string message = emailNotification.Message;
            string subject = emailNotification.Subject;
        }
    }

}
