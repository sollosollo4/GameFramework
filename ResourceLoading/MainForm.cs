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
        List<Framework.source.scripts.world.ItemEntity> addingItems;

        public MainForm()
        {
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

                commonItem.ItemName = new Framework.source.scripts.world.ItemName().GetItemName(ItemNameTextBox.Text, Convert.ToInt32(comboBox1.SelectedValue));

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    { 
                        CharacterName = "DamageType", 
                        CharacterValue = comboBox2.Text == "Physical" ? 0 : 1
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "Damage",
                        CharacterValue = Convert.ToInt32(DamageTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "Agility",
                        CharacterValue = Convert.ToInt32(AgilityTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "Force",
                        CharacterValue = Convert.ToInt32(ForceTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "Intellect",
                        CharacterValue = Convert.ToInt32(IntellectTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "FireM",
                        CharacterValue = Convert.ToInt32(FireMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "IceM",
                        CharacterValue = Convert.ToInt32(IceMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "NatureM",
                        CharacterValue = Convert.ToInt32(NatureMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "LigthM",
                        CharacterValue = Convert.ToInt32(LigthMTextBox.Text)
                    });

                commonItem.IntableCharacters.Add(
                    new Framework.source.scripts.world.ItemCharacter<int>()
                    {
                        CharacterName = "DarkM",
                        CharacterValue = Convert.ToInt32(DarkMTextBox.Text)
                    });

                addingItems.Add(commonItem);

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Framework.source.scripts.world.ItemsManager.ResourceFileSave, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, addingItems);
                }
            }
            else
            {
                Framework.source.scripts.world.Items.ScriptableItems commonItem = new Framework.source.scripts.world.Items.ScriptableItems();

                var scripts = ScriptsNamesTextBox.Text.Split(';');
                foreach (string ScriptName in scripts)
                {
                    commonItem.StringableCharacters.Add(
                        new Framework.source.scripts.world.ItemCharacter<string>()
                        {
                            CharacterName = "ScriptName",
                            CharacterValue = ScriptName
                        });
                }
            }

        }
    }
}
