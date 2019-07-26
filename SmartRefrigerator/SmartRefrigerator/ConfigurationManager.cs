using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class ConfigurationManager
    {
        private IStorage _storage;
        
        public ConfigurationManager(IStorage storage)
        {
            _storage = storage;
        }

        public void SetMinimumQuantity(Vegetable vegetable, int quantity)
        {
            _storage.SetVegetableMinimumQuantity(vegetable, quantity);
        }

        public int GetMinimumQuantity(Vegetable vegetable)
        {
            return _storage.GetVegetableMinimumQuantity(vegetable);
        }

        /*public INotifier SetNotificationClass(string message)
        {
            switch (message.ToLowerInvariant())
            {
                case "textnotifier" :
                    return new TextNotifier();
                case "emailnotifier":
                    return new EmailNotifier();
                default:
                    throw new NotSupportedException();
            }
        }*/

    }
}
