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

        public MainScript mainScript;
        public ItemsManager(MainScript mainScript)
        {
            this.mainScript = mainScript;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(ResourceFileSave, FileMode.Open))
            {
                ItemEntities = (List<ItemEntity>)formatter.Deserialize(fs);
            }

            //set mainScript
            foreach(var itm in ItemEntities) {
                itm.MainScript = mainScript;
            }
        }
    }
}
