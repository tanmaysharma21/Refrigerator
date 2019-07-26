using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class Refrigerator
    {
        private VegetableTray _vegetableTray = new VegetableTray();
        private ConfigurationManager _configurationManager = new ConfigurationManager(new InMemoryStorage());
        private INotifier _notifier;
        //private INotifier _notifier;

        /*public Refrigerator(INotifier notifier)xs
        {

        }*/
        

        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.AddVegetable(vegetable, quantity);
        }

        public string TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.TakeOutVegetable(vegetable, quantity);

            int currentQuantity = _vegetableTray.VegetableCurrentQuantity(vegetable);
            int minimumQuantityRequire = _configurationManager.GetMinimumQuantity(vegetable);

            if (currentQuantity < minimumQuantityRequire)
            {
                NotifierFactory notifierFactory = new NotifierFactory();
                _notifier = notifierFactory.CreateNotifier(vegetable, minimumQuantityRequire - quantity, "TextNotifier");
                _notifier.Notify();

            }

            return "vegetable "+vegetable.Name+" left is "+currentQuantity;

        }

        public void SetMinimumQuantity(Vegetable vegetable, int quantity)
        {
            _configurationManager.SetMinimumQuantity(vegetable, quantity);
        }

        public List<KeyValuePair<Vegetable, int>> GetVegetableQuantity()
        {
            return _vegetableTray.GetVegetableQuantity();
        }

    }
}
