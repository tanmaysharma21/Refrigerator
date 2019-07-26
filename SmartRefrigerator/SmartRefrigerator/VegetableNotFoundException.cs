using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class VegetableNotFoundException : Exception
    {
        public VegetableNotFoundException(String message) : base(message)
        {

        }
    }
}
