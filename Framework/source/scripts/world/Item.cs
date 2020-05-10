using Framework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.source.scripts.world
{
    public interface Item
    {
        int ID { get; set; }
        ItemName ItemName { get; set; }
        List<ItemCharacter<int>> IntableCharacters { get; set; }
        List<ItemCharacter<string>> StringableCharacters { get; set; }
        Image ItemIcon { get; set; }
    }

    [Serializable]
    public abstract class ItemEntity : Item
    {
        public ItemEntity()
        {
            ItemName = new ItemName();
            IntableCharacters = new List<ItemCharacter<int>>();
            StringableCharacters = new List<ItemCharacter<string>>();
        }

        [NonSerialized]
        public MainScript MainScript;

        public virtual ItemName ItemName { get; set; }
        public virtual List<ItemCharacter<int>> IntableCharacters { get; set; }
        public virtual List<ItemCharacter<string>> StringableCharacters { get; set; }
        public virtual Image ItemIcon { get; set; }

        public abstract int ID { get; set; }

        public virtual void ItemEquip(ItemEntity item, ItemBox sender)
        {
            MainScript.SetItem(item, sender);
            MainScript.Player.SetItem(item);
        }
    }
}
