using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.source.scripts.world
{
    [Serializable]
    public class ItemCharacter<T>
    {
        public static readonly string[] CharacterNames = new string[]
        {
            "DamageType",
            "Damage",
            "Agility",
            "Force",
            "Intellect",
            "FireM",
            "IceM",
            "NatureM",
            "LigthM",
            "DarkM",
            "EquipType"
        };

        public enum CharacterNamesT : int
        {
            DamageType,
            Damage,
            Agility,
            Force,
            Intellect,
            FireM,
            IceM,
            NatureM,
            LigthM,
            DarkM,
            EquipType
        }

        public static readonly string[] EquipTypeValues = new string[]
        {
            "Head",
            "Burclet",
            "Plate",
            "Buwer",
            "Hand",
            "Jeans",
            "Shoe",
            "Difficulty",
            "MainWeapon",
            "SecondWeapon"
        };

        public string CharacterName { get; set; }
        public T CharacterValue { get; set; }

        public static List<ItemCharacter<T>> loadCharacters()
        {
            List<ItemCharacter<T>> itemCharacteristic = new List<ItemCharacter<T>>();
            return itemCharacteristic;
        }

        public static ItemCharacter<T> GetItemCharacter(string name, T value)
        {
            return new ItemCharacter<T>() { CharacterName = name, CharacterValue = value };
        }
    }
}