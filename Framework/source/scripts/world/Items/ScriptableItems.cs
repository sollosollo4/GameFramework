using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world.Items
{
    [Serializable]
    public class ScriptableItems : ItemEntity
    {
        private int id;
        public override int ID { get => id; set => id = value; }

        public delegate EventHandler Script();
        public Script ScriptDelegate;

        public ScriptableItems(Script scriptDelegate)
        {
            ScriptDelegate += scriptDelegate;
        }

        public ScriptableItems()
        {
        }

        public void ActiveScript()
        {
            ScriptDelegate();
        }
    }
}
