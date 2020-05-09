﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world
{
    public interface Item
    {
        ItemName ItemName { get; set; }
        List<ItemCharacter<int>> IntableCharacters { get; set; }
        List<ItemCharacter<string>> StringableCharacters { get; set; }
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

        public virtual ItemName ItemName { get; set; }
        public virtual List<ItemCharacter<int>> IntableCharacters { get; set; }
        public virtual List<ItemCharacter<string>> StringableCharacters { get; set; }
    }
}