﻿using System;
using System.Collections.Generic;

namespace Framework.source.scripts.world
{
    [Serializable]
    public class ItemCharacter<T>
    {
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