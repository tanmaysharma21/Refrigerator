using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    class FileBased : IStorage
    {
        private Dictionary<Vegetable, int> _vegetableQuantity = new Dictionary<Vegetable, int>();

        public void SetVegetableMinimumQuantity(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
                _vegetableQuantity[vegetable] = quantity;
            else
                _vegetableQuantity.Add(vegetable, quantity);
        }

        public int GetVegetableMinimumQuantity(Vegetable vegetable)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
                return _vegetableQuantity[vegetable];

            throw new VegetableNotFoundException("Vegetable not found");
        }

    }
}
