using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public interface INotification
    {
        string Message { get;}
    }

    public interface IEmailNotification : INotification
    {
        string Subject { get;  }
    }

    public class TextNotification : INotification
    {
        Vegetable vegetable;
        int quantity;
        public TextNotification(Vegetable vegetable, int quantity)
        {
            this.vegetable = vegetable;
            this.quantity = quantity;
        }

        public string Message
        {
            get
            {
                return vegetable + " is less by " + quantity;
            }
        }
    }

    public class EmailNotification : IEmailNotification
    {
        Vegetable vegetable;
        int quantity;
        public EmailNotification(Vegetable vegetable, int quantity)
        {
            this.vegetable = vegetable;
            this.quantity = quantity;
        }

        public string Message
        {
            get
            {
                return vegetable + " is less by " + quantity;
            }
        }

        public string Subject
        {
            get
            {
                return vegetable + " is less";
            }
        }

    }

}
