﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.source.scripts.world;
using Framework.source.scripts.world.Items;

namespace Framework.source.scripts.auth
{
    public class Player
    {
        public class PlayerCharacteristic : INotifyPropertyChanged
        {
            public static readonly string[] CharacterNames = new string[]
            {
                "PhysDamage",
                "MagDamage",
                "AgilityS",
                "ForceS",
                "IntellectS",
                "FireSM",
                "IceSM",
                "NatureSM",
                "LigthSM",
                "DarkSM",
                "DmgType"
            };

            public enum CharacterNamesT : int
            {
                PhysDamage,
                MagDamage,
                Agility,
                Force,
                Intellect,
                FireM,
                IceM,
                NatureM,
                LigthM,
                DarkM
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                PropertyChanged?.Invoke(this, e);
            }

            protected void OnPropertyChanged(string propertyName)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }
            
            private int charValue;

            public string CharacterName { get; set; }

            public int CharacterValue { 
                get => charValue; 
                set {
                    if (value != charValue)
                    {
                        charValue = value;
                        OnPropertyChanged("CharacterValue");
                    }
                } 
            } 

            public PlayerCharacteristic(string PC_Name, int value)
            {
                CharacterName = PC_Name;
                charValue = value;
            }
        }

        public void SetItem(ItemEntity item)
        {
            var AddDamage = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Damage]).CharacterValue;

            var AddAgility = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Agility]).CharacterValue;

            var AddForce = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Force]).CharacterValue;

            var AddIntellect = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Intellect]).CharacterValue;


            var AddFireM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.FireM]).CharacterValue;

            var AddIceM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.IceM]).CharacterValue;

            var AddNatureM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.NatureM]).CharacterValue;

            var AddLigthM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.LigthM]).CharacterValue;

            var AddDarkM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DarkM]).CharacterValue;


            if(item.IntableCharacters.FirstOrDefault( x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DamageType]).CharacterValue == 0)
                PlayerCharacteristics.FirstOrDefault(
                    x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.PhysDamage])
                    .CharacterValue += AddDamage;
            else
                PlayerCharacteristics.FirstOrDefault(
                    x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.MagDamage])
                    .CharacterValue += AddDamage;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Agility])
                .CharacterValue += AddAgility;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Force])
                .CharacterValue += AddForce;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Intellect])
                .CharacterValue += AddIntellect;


            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.FireM])
                .CharacterValue += AddFireM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.IceM])
                .CharacterValue += AddIceM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.NatureM])
                .CharacterValue += AddNatureM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.LigthM])
                .CharacterValue += AddLigthM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.DarkM])
                .CharacterValue += AddDarkM;
        }

        public void DesetItem(ItemEntity item)
        {
            var AddDamage = item.IntableCharacters.FirstOrDefault(
                 x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Damage]).CharacterValue;

            var AddAgility = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Agility]).CharacterValue;

            var AddForce = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Force]).CharacterValue;

            var AddIntellect = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Intellect]).CharacterValue;


            var AddFireM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.FireM]).CharacterValue;

            var AddIceM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.IceM]).CharacterValue;

            var AddNatureM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.NatureM]).CharacterValue;

            var AddLigthM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.LigthM]).CharacterValue;

            var AddDarkM = item.IntableCharacters.FirstOrDefault(
                x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DarkM]).CharacterValue;

            if (item.IntableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DamageType]).CharacterValue == 0)
                PlayerCharacteristics.FirstOrDefault(
                    x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.PhysDamage])
                    .CharacterValue -= AddDamage;
            else
                PlayerCharacteristics.FirstOrDefault(
                    x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.MagDamage])
                    .CharacterValue -= AddDamage;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Agility])
                .CharacterValue -= AddAgility;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Force])
                .CharacterValue -= AddForce;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.Intellect])
                .CharacterValue -= AddIntellect;


            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.FireM])
                .CharacterValue -= AddFireM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.IceM])
                .CharacterValue -= AddIceM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.NatureM])
                .CharacterValue -= AddNatureM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.LigthM])
                .CharacterValue -= AddLigthM;

            PlayerCharacteristics.FirstOrDefault(
                x => x.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.DarkM])
                .CharacterValue -= AddDarkM;
        }

        public MainScript mainScript;
        public List<ItemEntity> BackPack;
        public List<ResourceItems> Inventory;

        private List<PlayerCharacteristic> PlayerCharacteristics;

        public Player(MainScript mainScript)
        {
            this.mainScript = mainScript;

            PlayerCharacteristics = new List<PlayerCharacteristic>();
            SetDefaultPlayerCharacteristics();

            foreach (var chr in PlayerCharacteristics) {
                chr.PropertyChanged += Chr_PropertyChanged;
            }
        }

        private void SetDefaultPlayerCharacteristics()
        {
            PlayerCharacteristics.Add(new PlayerCharacteristic("PhysDamage", 21));
            PlayerCharacteristics.Add(new PlayerCharacteristic("MagDamage", 21));

            PlayerCharacteristics.Add(new PlayerCharacteristic("AgilityS", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("ForceS", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("IntellectS", 3));

            PlayerCharacteristics.Add(new PlayerCharacteristic("FireSM", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("IceSM", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("NatureSM", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("LigthSM", 3));
            PlayerCharacteristics.Add(new PlayerCharacteristic("DarkSM", 3));
        }

        private void Chr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var actuallySender = (PlayerCharacteristic)sender;
            var index = getCurrectlyCode(actuallySender.CharacterName);
            var indexAspect = getCurrectlyAspectCode(actuallySender.CharacterName);

            if (index != -1)
                mainScript.AFILabels[index].Text = actuallySender.CharacterValue.ToString();

            if (indexAspect != -1)
                mainScript.AspectsLabel[indexAspect].Text = actuallySender.CharacterValue.ToString();
            
            if(actuallySender.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.MagDamage])
                mainScript.DmgInfolabel[0].Text = actuallySender.CharacterValue.ToString();

            if (actuallySender.CharacterName == PlayerCharacteristic.CharacterNames[(int)PlayerCharacteristic.CharacterNamesT.PhysDamage])
                mainScript.DmgInfolabel[1].Text = actuallySender.CharacterValue.ToString();
        }

        private int getCurrectlyAspectCode(string characterName)
        {
            switch (characterName)
            {
                case "FireSM":
                    return 0;

                case "IceSM":
                    return 1;

                case "NatureSM":
                    return 2;

                case "LigthSM":
                    return 3;

                case "DarkSM":
                    return 4;

                default:
                    return -1;
            }
        }

        private int getCurrectlyCode(string characterName)
        {
            switch(characterName)
            {
                case "ForceS":
                    return 0;

                case "AgilityS":
                    return 1;

                case "IntellectS":
                    return 2;

                default:
                    return -1;
            }
        }
    }
}
