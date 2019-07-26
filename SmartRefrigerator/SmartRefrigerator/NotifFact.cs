using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class NotifierFactory
    {
        public INotifier CreateNotifier(Vegetable vegetable, int quantity, string notifierType)
        {
            switch (notifierType.ToLowerInvariant())
            {
                case "textnotifier" :
                    return new TextNotifier(vegetable, quantity);
                case "emailnotifier":
                    return new EmailNotifier(vegetable, quantity);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
