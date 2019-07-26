using System;
using Xunit;
using System.Collections.Concurrent;
using SmartRefrigerator;
using System.Collections.Generic;

namespace SmartRefrigerator.Tests
{
    public class RefrigeratorTest
    {
        private Refrigerator _refrigerator = new Refrigerator();
        Vegetable tomato = new Tomato();
        Vegetable cabbage = new Cabbage();

        public RefrigeratorTest()
        {
            _refrigerator.AddVegetable(tomato, 9);
            _refrigerator.AddVegetable(cabbage, 6);
            _refrigerator.SetMinimumQuantity(tomato, 5);
            _refrigerator.SetMinimumQuantity(cabbage, 4);
        }

        [Fact]
        public void AddVegetable()
        {
            _refrigerator.AddVegetable(tomato, 6);
            List<KeyValuePair<Vegetable, int>> list = new List<KeyValuePair<Vegetable, int>>();
            list.Add(new KeyValuePair<Vegetable, int>(tomato, 15));
            list.Add(new KeyValuePair<Vegetable, int>(cabbage, 6));

            Assert.Equal(list, _refrigerator.GetVegetableQuantity());

        }

        [Fact]
        public void RemoveVegetable()
        {
            
            string returnValue = "vegetable Tomato left is 6";
            Assert.Equal(returnValue, _refrigerator.TakeOutVegetable(tomato, 3));
        }

        [Fact]
        public void RemoveVegetableMoreThanMinimumQuantity()
        {
            string returnValue = "The vegetable Cabbage is less by 1";
            Assert.Equal(returnValue, _refrigerator.TakeOutVegetable(cabbage, 3));
        }

        [Fact]
        public void RemoveNotPresentVegetable()
        {
            _refrigerator.TakeOutVegetable(cabbage, 8);
            //var removeVegetable = _refrigerator.TakeOutVegetable(cabbage, 8);
            Assert.Throws<VegetableNotFoundException>(() => _refrigerator.TakeOutVegetable(cabbage, 1));

        }

        [Fact]
        public void ObjectVerification()
        {
            StorageFactory storageFactory = new StorageFactory();
            var obj = storageFactory.GetStorage("inmemory");
            Assert.Equal(obj.GetType(), typeof(InMemoryStorage));

        }

    }
}
