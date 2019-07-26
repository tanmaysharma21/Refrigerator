using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefrigerator
{
    public class StorageFactory
    {
        public IStorage GetStorage(string storageType)
        {
            switch (storageType.ToLowerInvariant())
            {
                case "inmemory":
                    return new InMemoryStorage();
                case "filebased":
                    return new FileBased();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
