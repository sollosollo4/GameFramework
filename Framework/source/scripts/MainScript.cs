using Framework.Controls;
using Framework.source.scripts.auth;
using Framework.source.scripts.world;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Framework.source
{
    public class MainScript
    {
        public Graphic graphic;
        public Player Player;
        public ItemsManager ItemsManager;

        public EventHandler eventHandler_HeroCharacteristic_Update;
        public TableLayoutPanel HeroInterfacePanel;
        public FlowLayoutPanel BackPackInterfacePanel;

        public Label[] AFILabels;

        public MainScript()
        {

        }

        public MainScript SetGraphicClass(ControlCollection controls, Color c1, Color c2)
        {
            graphic = new Graphic();
            graphic.SetAllButtonsMouseEvents(controls, Color.FromArgb(150, 166, 230, 230), Color.FromArgb(150, 0, 34, 12));
            return this;
        }

        public MainScript LoadAllScripts()
        {
            ItemsManager = new ItemsManager(this);
            Player = new Player(this);
            return this;
        }

        public List<ItemBox> GetAllItemBoxes()
        {
            List<ItemBox> ItemBoxs = new List<ItemBox>();
            int i = 0;
            foreach(var item in ItemsManager.ItemEntities)
            {
                ItemBoxs.Add(new ItemBox(item) { TabIndex = i } );
                i++;
            }
            return ItemBoxs;
        }

        public void SetItem(ItemEntity item, ItemBox sender)
        {
            var cellIndex = item.StringableCharacters.FirstOrDefault( x=> x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;

            sender.Margin = new Padding(0);
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Снять", null, UseItemBoxContextStrip);
            
            sender.IconPanel.ContextMenuStrip = contextMenuStrip;
            sender.IconPanel.MouseDown += ItemIcon_MouseDown;

            var control = HeroInterfacePanel.GetControlFromPosition(getColumn(cellIndex), getRow(cellIndex));

            if (control is PictureBox)
            {
                HeroInterfacePanel.Controls.Remove(control);
                BackPackInterfacePanel.Controls.Remove(sender);

                HeroInterfacePanel.Controls.Add(sender, getColumn(cellIndex), getRow(cellIndex));
            }
            else if(control is ItemBox)
            {            
                var itemBox = (ItemBox)control;
                ItemBox newItemBox = new ItemBox(itemBox.GetItemEntity);
                Player.DesetItem(itemBox.GetItemEntity);

                HeroInterfacePanel.Controls.Remove(control);
                HeroInterfacePanel.Controls.Add(sender, getColumn(cellIndex), getRow(cellIndex));

                BackPackInterfacePanel.Controls.Add(newItemBox);
            }
            else if(control is null)
            {
                HeroInterfacePanel.Controls.Remove(control);
                BackPackInterfacePanel.Controls.Remove(sender);

                HeroInterfacePanel.Controls.Add(sender, getColumn(cellIndex), getRow(cellIndex));
            }
        }        

        private void ItemIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var newTag = sender as Panel;
                newTag.ContextMenuStrip.Tag = newTag.Parent;
            }
        }

        private void UseItemBoxContextStrip(object sender, EventArgs e)
        {
            var panel = (ToolStripItem)sender;
            var stripmenu = panel.GetCurrentParent();
            var itembox = (ItemBox)stripmenu.Tag;
            var cellIndex = itembox.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;

            Player.DesetItem(itembox.GetItemEntity);

            var control = HeroInterfacePanel.GetControlFromPosition(getColumn(cellIndex), getRow(cellIndex));
            HeroInterfacePanel.Controls.Remove(control);

            ItemBox newItemBox = new ItemBox(itembox.GetItemEntity);
            BackPackInterfacePanel.Controls.Add(newItemBox);

            PictureBox pictureBox = new PictureBox() { 
                Image = getImage(cellIndex), 
                SizeMode = PictureBoxSizeMode.StretchImage,
                Margin = new Padding(0),
                Dock = DockStyle.Fill
            };
            HeroInterfacePanel.Controls.Add(pictureBox, getColumn(cellIndex), getRow(cellIndex));
        }

        public int getRow(string cellIndex)
        {
            switch(cellIndex)
            {
                case "Head":
                    return 0;
                case "Burclet":
                    return 1;
                case "Plate":
                    return 2;
                case "Buwer":
                    return 3;
                case "Hand":
                    return 0;
                case "Jeans":
                    return 1;
                case "Shoe":
                    return 2;
                case "Difficulty":
                    return 3;
                case "MainWeapon":
                    return 4;
                case "SecondWeapon":
                    return 4;
                default:
                    return -1;
            }
        }

        public int getColumn(string cellIndex)
        {
            switch (cellIndex)
            {
                case "Head":
                    return 0;
                case "Burclet":
                    return 0;
                case "Plate":
                    return 0;
                case "Buwer":
                    return 0;
                case "Hand":
                    return 5;
                case "Jeans":
                    return 5;
                case "Shoe":
                    return 5;
                case "Difficulty":
                    return 5;
                case "MainWeapon":
                    return 0;
                case "SecondWeapon":
                    return 0;
                default:
                    return -1;
            }
        }

        public Image getImage(string cellIndex)
        {
            switch (cellIndex)
            {
                case "Head":
                    return Properties.Resources.ItemHead;
                case "Burclet":
                    return Properties.Resources.ItemBurclet;
                case "Plate":
                    return Properties.Resources.ItemPlate;
                case "Buwer":
                    return Properties.Resources.ItemBuwer;
                case "Hand":
                    return Properties.Resources.ItemHand;
                case "Jeans":
                    return Properties.Resources.ItemJeans;
                case "Shoe":
                    return Properties.Resources.ItemShoe;
                case "Difficulty":
                    return Properties.Resources.ItemDifficulty;
                case "MainWeapon":
                    return Properties.Resources.ItemWeaponMain;
                case "SecondWeapon":
                    return Properties.Resources.ItemWeaponSecond;
                default:
                    return null;
            }
        }
    }
}
