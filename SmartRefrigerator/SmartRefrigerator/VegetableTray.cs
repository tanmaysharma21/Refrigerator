using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class VegetableTray
    {
        private Dictionary<Vegetable, int> _vegetableQuantity = new Dictionary<Vegetable, int>();
        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
            {
                _vegetableQuantity[vegetable] = _vegetableQuantity[vegetable] + quantity;
            }
            else
                _vegetableQuantity.Add(vegetable, quantity);
        }
        public void TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
            {
                _vegetableQuantity[vegetable] = _vegetableQuantity[vegetable] - quantity;
                if (_vegetableQuantity[vegetable] <= 0)
                    _vegetableQuantity.Remove(vegetable);
            }
            else
            {
                throw new VegetableNotFoundException("Vegetable not found");
            }

        }

        public List<KeyValuePair<Vegetable, int>> GetVegetableQuantity()
        {
            var vegetableQuantity = new List<KeyValuePair<Vegetable, int>>();
            foreach (var item in _vegetableQuantity)
            {
                vegetableQuantity.Add(new KeyValuePair<Vegetable, int>(item.Key, item.Value));

            }

            return vegetableQuantity;

        }

        public int VegetableCurrentQuantity(Vegetable vegetable)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
                return _vegetableQuantity[vegetable];
            
            return 0;
        }

    }
}
