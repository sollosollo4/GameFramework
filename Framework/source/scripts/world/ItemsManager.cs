using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world
{
    public class ItemsManager
    {
        public const string ResourceFileSave = @"..\..\..\..\MyGameTest\MyGameTest\bin\Debug\items.rsc";

        public List<ItemEntity> ItemEntities;
       
        public ItemsManager()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(ResourceFileSave, FileMode.Open))
            {
                ItemEntities = (List<ItemEntity>)formatter.Deserialize(fs);
            }
        }

    }
}
