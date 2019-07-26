using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public interface IStorage
    {
        void SetVegetableMinimumQuantity(Vegetable vegetable, int quantity);
        int GetVegetableMinimumQuantity(Vegetable vegetable);
    }
}
