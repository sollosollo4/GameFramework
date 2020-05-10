using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world.Items
{
    [Serializable]
    public class CommonItems : ItemEntity
    {
        public CommonItems()
        {
        }

        private int id;
        public override int ID { get => id; set => id = value; }
    }
}
