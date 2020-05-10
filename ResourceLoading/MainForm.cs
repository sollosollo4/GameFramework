using Framework.source.scripts.world;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceLoading
{
    public partial class MainForm : Form
    {
        List<ItemEntity> addingItems;
        ItemEntity CurrentItem;
        ItemEntity LastIndex;
        static int index;
        public MainForm()
        {
            index = 0;
            InitializeComponent();
            addingItems = new List<Framework.source.scripts.world.ItemEntity>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var comboBox1Items = new []
            {
                new {id = 0, name = "None"},
                new {id = 1, name = "Common"},
                new {id = 2, name = "Uncommon"},
                new {id = 3, name = "Rare"},
                new {id = 4, name = "Epic"},
                new {id = 5, name = "Legendary"},
                new {id = 6, name = "Unreal"}
            };
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            comboBox1.DataSource = comboBox1Items;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (ScriptsNamesTextBox.Text == string.Empty)
            {
                Framework.source.scripts.world.Items.CommonItems commonItem = new Framework.source.scripts.world.Items.CommonItems();

                commonItem.ItemIcon = ItemBitMap.Image;
                commonItem.ItemName = new ItemName().GetItemName(ItemNameTextBox.Text, Convert.ToInt32(comboBox1.SelectedValue));

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    { 
                        CharacterName = "DamageType", 
                        CharacterValue = comboBox2.Text == "Physical" ? 0 : 1
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "Damage",
                        CharacterValue = Convert.ToInt32(DamageTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "Agility",
                        CharacterValue = Convert.ToInt32(AgilityTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "Force",
                        CharacterValue = Convert.ToInt32(ForceTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "Intellect",
                        CharacterValue = Convert.ToInt32(IntellectTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "FireM",
                        CharacterValue = Convert.ToInt32(FireMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "IceM",
                        CharacterValue = Convert.ToInt32(IceMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "NatureM",
                        CharacterValue = Convert.ToInt32(NatureMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "LigthM",
                        CharacterValue = Convert.ToInt32(LigthMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new ItemCharacter<int>()
                    {
                        CharacterName = "DarkM",
                        CharacterValue = Convert.ToInt32(DarkMTextBox.Text)
                    });

                commonItem.StringableCharacters.Add(
                    new ItemCharacter<string>()
                    {
                        CharacterName = "EquipType",
                        CharacterValue = ItemEquip.SelectedItem.ToString()
                    });

                addingItems.Add(commonItem);
                CurrentItem = commonItem;
            }
            else
            {
                Framework.source.scripts.world.Items.ScriptableItems commonItem = new Framework.source.scripts.world.Items.ScriptableItems();

                var scripts = ScriptsNamesTextBox.Text.Split(';');
                foreach (string ScriptName in scripts)
                {
                    commonItem.StringableCharacters.Add(
                        new ItemCharacter<string>()
                        {
                            CharacterName = "ScriptName",
                            CharacterValue = ScriptName
                        });
                }
            }

        }

        private void ItemBitMap_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                ItemBitMap.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(ItemsManager.ResourceFileSave, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, addingItems);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LastIndex == null)
                return;
            index--;
            CurrentItem = LastIndex;

            //ScriptsNamesTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault(x => x.CharacterName == "sctipt").CharacterValue;

            AgilityTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Agility]).CharacterValue;

            DamageTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Damage]).CharacterValue;

            DarkMTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DarkM]).CharacterValue;

            FireMTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.FireM]).CharacterValue;

            ForceTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Force]).CharacterValue;

            IceMTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.IceM]).CharacterValue;

            IntellectTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Intellect]).CharacterValue;

            ItemNameTextBox.Text = CurrentItem.ItemName.Name;

            LigthMTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.LigthM]).CharacterValue;

            NatureMTextBox.Text = CurrentItem.StringableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.NatureM]).CharacterValue;

            NeedLevelTextBox.Text = "0";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
                return;
            index++;

            ScriptsNamesTextBox.Text = "";
            AgilityTextBox.Text = "";
            DamageTextBox.Text = "";
            DarkMTextBox.Text = "";
            FireMTextBox.Text = "";
            ForceTextBox.Text = "";
            IceMTextBox.Text = "";
            IntellectTextBox.Text = "";
            ItemNameTextBox.Text = "";
            LigthMTextBox.Text = "";
            NatureMTextBox.Text = "";
            NeedLevelTextBox.Text = "";
            
            LastIndex = CurrentItem;
        }
    }
}
