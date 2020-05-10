using Framework.source.scripts.world.Items;
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

        public const string ResourceFile = @"..\..\..\..\MyGameTest\MyGameTest\bin\Debug\resource.rsc";

        public List<ItemEntity> ItemEntities;
        public List<ResourceItems> ResourceItems;

        public MainScript mainScript;
        public ItemsManager(MainScript mainScript)
        {
            this.mainScript = mainScript;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(ResourceFileSave, FileMode.Open))
            {
                ItemEntities = (List<ItemEntity>)formatter.Deserialize(fs);
            }

            //using (FileStream fs = new FileStream(ResourceFile, FileMode.Open))
            //{
            //    ResourceItems = (List<ResourceItems>)formatter.Deserialize(fs);
            //}
            
            foreach(var itm in ItemEntities) {
                itm.MainScript = mainScript;
            }
        }
    }
}
