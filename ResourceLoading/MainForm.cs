using Framework.Controls;
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
        ItemBox CurrentItemBox;

        static int ItemID;

        public MainForm()
        {
            InitializeComponent();
            addingItems = new List<ItemEntity>();

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(ItemsManager.ResourceFileSave, FileMode.Open))
                {
                    addingItems = (List<ItemEntity>)formatter.Deserialize(fs);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Программа начала работу с начала. Все данные были уничтожены, либо не удалось найти файл ресурсов по указанному пути: " + e.Message);
            }

            if (addingItems.Count > 0)
            {
                ItemID = addingItems.LastOrDefault().ID;
                foreach (var ctrl in addingItems)
                {
                    ItemBox itemBox = new ItemBox(ctrl, true);
                    itemBox.IconPanel.Click += IconPanel_Click;
                    flowLayoutPanel1.Controls.Add(itemBox);
                }
            }
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
            CheckAllTextBox();

            if (ScriptsNamesTextBox.Text == string.Empty)
            {
                Framework.source.scripts.world.Items.CommonItems commonItem = new Framework.source.scripts.world.Items.CommonItems();

                if(ItemBitMap.Image != null)
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
                ItemID++;
                CurrentItem = commonItem;

                ItemBox itemBox = new ItemBox(commonItem, true);
                itemBox.IconPanel.Click += IconPanel_Click;
                flowLayoutPanel1.Controls.Add(itemBox);
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

        private void CheckAllTextBox()
        {
            if(AgilityTextBox.Text == "")
                AgilityTextBox.Text = "0";

            if (DamageTextBox.Text == "")
                DamageTextBox.Text = "0";

            if (DarkMTextBox.Text == "")
                DarkMTextBox.Text = "0";

            if (FireMTextBox.Text == "")
                FireMTextBox.Text = "0";

            if (ForceTextBox.Text == "")
                ForceTextBox.Text = "0";

            if (IceMTextBox.Text == "")
                IceMTextBox.Text = "0";

            if (IntellectTextBox.Text == "")
                IntellectTextBox.Text = "0";

            if (ItemNameTextBox.Text == "")
                ItemNameTextBox.Text = "Name"; 

            if (LigthMTextBox.Text == "")
                LigthMTextBox.Text = "0";

            if (NatureMTextBox.Text == "")
                NatureMTextBox.Text = "0";

            if (NeedLevelTextBox.Text == "")
                NeedLevelTextBox.Text = "0";

        }

        private void IconPanel_Click(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            var itemBox = (ItemBox)panel.Parent;

            CurrentItemBox = itemBox;
            CurrentItem = itemBox.GetItemEntity;

            ItemBitMap.Image = CurrentItem.ItemIcon;

            AgilityTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Agility]).CharacterValue.ToString();

            DamageTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Damage]).CharacterValue.ToString();

            DarkMTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DarkM]).CharacterValue.ToString();

            FireMTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.FireM]).CharacterValue.ToString();

            ForceTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Force]).CharacterValue.ToString();

            IceMTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.IceM]).CharacterValue.ToString();

            IntellectTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Intellect]).CharacterValue.ToString();

            ItemNameTextBox.Text = CurrentItem.ItemName.Name;

            LigthMTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.LigthM]).CharacterValue.ToString();

            NatureMTextBox.Text = CurrentItem.IntableCharacters.SingleOrDefault
                (x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.NatureM]).CharacterValue.ToString();

            comboBox1.SelectedIndex = CurrentItem.ItemName.Quality;
            comboBox2.SelectedItem = CurrentItem.IntableCharacters.SingleOrDefault(x => x.CharacterName == ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DamageType]).CharacterValue == 0 ? "Physical" : "Magical";
            ItemEquip.SelectedItem = CurrentItem.StringableCharacters.SingleOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;


            NeedLevelTextBox.Text = "0";
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
            using (FileStream fs = new FileStream(ItemsManager.ResourceFileSave, FileMode.Create))
            {
                formatter.Serialize(fs, addingItems);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgilityTextBox.Text = "0";
            DamageTextBox.Text = "0";
            DarkMTextBox.Text = "0";
            FireMTextBox.Text = "0";
            ForceTextBox.Text = "0";
            IceMTextBox.Text = "0";
            IntellectTextBox.Text = "0";
            ItemNameTextBox.Text = "Name";
            LigthMTextBox.Text = "0";
            NatureMTextBox.Text = "0";
            NeedLevelTextBox.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckAllTextBox();

            flowLayoutPanel1.Controls.Remove(CurrentItemBox);
            
            CurrentItem.ItemIcon = ItemBitMap.Image;
            CurrentItem.ItemName = new ItemName().GetItemName(ItemNameTextBox.Text, Convert.ToInt32(comboBox1.SelectedValue));

            CurrentItem.IntableCharacters.Clear();

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "DamageType",
                    CharacterValue = comboBox2.Text == "Physical" ? 0 : 1
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "Damage",
                    CharacterValue = Convert.ToInt32(DamageTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "Agility",
                    CharacterValue = Convert.ToInt32(AgilityTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "Force",
                    CharacterValue = Convert.ToInt32(ForceTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "Intellect",
                    CharacterValue = Convert.ToInt32(IntellectTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "FireM",
                    CharacterValue = Convert.ToInt32(FireMTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "IceM",
                    CharacterValue = Convert.ToInt32(IceMTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "NatureM",
                    CharacterValue = Convert.ToInt32(NatureMTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "LigthM",
                    CharacterValue = Convert.ToInt32(LigthMTextBox.Text)
                });

            CurrentItem.IntableCharacters.Add(
                new ItemCharacter<int>()
                {
                    CharacterName = "DarkM",
                    CharacterValue = Convert.ToInt32(DarkMTextBox.Text)
                });

            CurrentItem.StringableCharacters.Clear();

            CurrentItem.StringableCharacters.Add(
                new ItemCharacter<string>()
                {
                    CharacterName = "EquipType",
                    CharacterValue = ItemEquip.SelectedItem.ToString()
                });

            ItemBox itemBox = new ItemBox(CurrentItem, true);
            flowLayoutPanel1.Controls.Add(itemBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentItem != null && CurrentItemBox != null)
            {
                addingItems.Remove(CurrentItem);
                flowLayoutPanel1.Controls.Remove(CurrentItemBox);
            }
        }
    }
}
