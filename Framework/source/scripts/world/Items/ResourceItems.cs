using Framework.source.scripts.world.ItemsScripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world.Items
{
    [Serializable]
    public class ResourceItems : ItemEntity, IStackable
    {
        private int id;
        public override int ID { get => id; set => id = value; }

        public int Count { get => count; set => count = value; }
        public int MaxCount { get => maxCount; set => maxCount = value; }
        int count;
        int maxCount;

        public List<ItemCharacter> ItemCharacters;

        public ResourceItems(ItemEntity baseItem, int maxCount)
        {
            ItemName = baseItem.ItemName;
            MainScript = baseItem.MainScript;
            ItemIcon = baseItem.ItemIcon;

            MaxCount = maxCount;

            ItemCharacters = new List<ItemCharacter>()
            {
                new ItemCharacter(this, ItemCharacter.ItemCharacterStackable[(int)ItemCharacter.ItemCharacterStackableT.MaxCount], MaxCount.ToString())
            };
        }
    }
}
