using System;
using System.Drawing;

namespace Framework.source.scripts.world
{
    [Serializable]
    public class ItemName
    {
        public string Name;

        public int Quality;

        public Color QualityColor;

        public string QualityName;

        public ItemQuality CurrentItemQuality;


        public enum ItemQuality : int
        {
            None = 0, 
            Common = 1,
            Uncommon = 2,
            Rare = 3,
            Epic = 4,
            Legendary = 5,
            Unreal = 6
        }

        private readonly Color[] ItemQualityColors = new Color[(int)ItemQuality.Unreal + 1]
        {
            Color.DarkSlateGray,
            Color.LightGray,
            Color.PaleGreen,
            Color.RoyalBlue,
            Color.DarkMagenta,
            Color.Orange,
            Color.OrangeRed
        };

        public readonly string[] ItemQualityNames = new string[(int)ItemQuality.Unreal + 1]
        {
            "Безделица",
            "Обычный",
            "Необычный",
            "Редкий",
            "Эпический",
            "Легендарный",
            "Невозможный",
        };


        public ItemName GetItemName(string name, ItemQuality itemQuality)
        {
            return new ItemName() { 
                Name = name,
                CurrentItemQuality = itemQuality,
                Quality = (int)itemQuality, 
                QualityColor = ItemQualityColors[(int)itemQuality],
                QualityName = ItemQualityNames[(int)itemQuality],
            };
        }

        public ItemName GetItemName(string name, int itemQuality)
        {
            return new ItemName()
            {
                Name = name,
                CurrentItemQuality = getQuality(itemQuality),
                Quality = itemQuality,
                QualityColor = ItemQualityColors[itemQuality],
                QualityName = ItemQualityNames[itemQuality],
            };
        }

        private ItemQuality getQuality(int itemQuality)
        {
            switch(itemQuality)
            {
                case 0:
                    return ItemQuality.None;
                case 1:
                    return ItemQuality.Common;
                case 2:
                    return ItemQuality.Uncommon;
                case 3:
                    return ItemQuality.Rare;
                case 4:
                    return ItemQuality.Epic;
                case 5:
                    return ItemQuality.Legendary;
                case 6: 
                    return ItemQuality.Unreal;
                default:
                    throw new Exception("Попытка инициализировать getQuality с невозможным параметром. ItemName.cs:94");
            }
        }
    }
}