using Framework.source.scripts.world;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.Controls
{
    public partial class ItemBox : Panel
    {
        public MultiToolTip MultiToolTip;
        public ItemEntity GetItemEntity;
        ContextMenuStrip contextMenuStrip;
        public Panel IconPanel;

        public bool isVisibleChange;

        public ItemBox(ItemEntity item)
        {
            GetItemEntity = item;
            InitializeComponent();

            AllowDrop = true;

            Size = new Size(60, 60);
            Location = new Point(0, 0);
            
            BackColor = item.ItemName.QualityColor;

            Panel ItemIcon = new Panel()
            {
                Location = new Point(3, 3),
                Size = new Size(54, 54),
                BackgroundImage = item.ItemIcon,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent
            };

            ItemIcon.MouseEnter += ItemIcon_MouseEnter;
            ItemIcon.MouseLeave += ItemIcon_MouseLeave;
            ItemIcon.AllowDrop = true;
            
            ItemIcon.MouseDown += ItemIcon_MouseDown;
            
            ItemIcon.DragEnter += ItemBox_DragEnter;
            ItemIcon.DragDrop += ItemIcon_DragDrop;

            Controls.Add(ItemIcon);
            IconPanel = ItemIcon;

            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Надеть", null, UseItemBoxContextStrip);
            contextMenuStrip.Items.Add("Удалить", null, DeleteItemBoxContextStrip);
            this.ContextMenuStrip = contextMenuStrip;
            
            MultiToolTip = new MultiToolTip(item);
        }

        public ItemBox(ItemEntity item, bool trueFl)
        {
            GetItemEntity = item;
            isVisibleChange = trueFl;
            InitializeComponent();
            
            Size = new Size(60, 60);
            Location = new Point(0, 0);

            BackColor = item.ItemName.QualityColor;

            Panel ItemIcon = new Panel()
            {
                Location = new Point(3, 3),
                Size = new Size(54, 54),
                BackgroundImage = item.ItemIcon,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent
            };

            ItemIcon.MouseEnter += ItemIcon_MouseEnter;
            ItemIcon.MouseLeave += ItemIcon_MouseLeave;
            
            Controls.Add(ItemIcon);
            IconPanel = ItemIcon;

            MultiToolTip = new MultiToolTip(item);
        }

        private void DeleteItemBoxContextStrip(object sender, EventArgs e)
        {
            var panel = (ItemBox)contextMenuStrip.Tag;
            var stackPanel = (FlowLayoutPanel)panel.Parent;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот предмет?", "Вы уверены", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                stackPanel.Controls.Remove(panel);
            else
                return;
        }

        internal void RemoveAllEvents()
        {
            IconPanel.MouseDown -= ItemIcon_MouseDown;
            IconPanel.DragEnter -= ItemBox_DragEnter;
            IconPanel.DragDrop -= ItemIcon_DragDrop;
        }

        private void UseItemBoxContextStrip(object sender, EventArgs e)
        {
            GetItemEntity.ItemEquip(GetItemEntity, this);
        }

        private void ItemIcon_DragDrop(object sender, DragEventArgs e)
        {
            var pol = (Panel)sender; // на кого
            var objectToDrag = (Panel)e.Data.GetData(typeof(Panel)); // кто
            Control flowLayoutPanelDrop = null;
            if (pol == null)
                flowLayoutPanelDrop = (FlowLayoutPanel)sender; // если мы кидаем на Flow LayoutPanel


            var ItemBoxPanel = (ItemBox)pol.Parent; // на кого
            var ItemBoxPanel2 = (ItemBox)objectToDrag.Parent;// кто

            Control parentFlowLayoutPanel = ItemBoxPanel.Parent; // родитель панели на которую мы кидаем
            Control parentFlowLayoutPanel0 = ItemBoxPanel2.Parent; // родитель панель с которой кидаем

            if (parentFlowLayoutPanel is FlowLayoutPanel && parentFlowLayoutPanel0 is FlowLayoutPanel)
            {
                var Panel = (FlowLayoutPanel)parentFlowLayoutPanel;

                int newIndex = 0;
                newIndex = Panel.Controls.IndexOf(ItemBoxPanel2);

                Panel.Controls.SetChildIndex(ItemBoxPanel, newIndex);
            }
            else if (parentFlowLayoutPanel0 is TableLayoutPanel && parentFlowLayoutPanel is FlowLayoutPanel)
            {
                var TablePanel = (TableLayoutPanel)parentFlowLayoutPanel0;
                var flowLayoutPanel = (FlowLayoutPanel)parentFlowLayoutPanel;

                var cellIndex = ItemBoxPanel.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;
                var cellIndex0 = ItemBoxPanel2.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;

                if (cellIndex == cellIndex0)
                {
                    TablePanel.Controls.Remove(ItemBoxPanel2); // Снимаем 
                    ItemBoxPanel2.GetItemEntity.MainScript.Player.DesetItem(ItemBoxPanel2.GetItemEntity);

                    flowLayoutPanel.Controls.Remove(ItemBoxPanel); // Надеваем
                    ItemBoxPanel.GetItemEntity.MainScript.Player.SetItem(ItemBoxPanel.GetItemEntity);

                    var newItemBox = new ItemBox(ItemBoxPanel2.GetItemEntity);
                    var newItemBox0 = new ItemBox(ItemBoxPanel.GetItemEntity) { Margin = new Padding(0) };

                    TablePanel.Controls.Add(newItemBox0, getColumn(cellIndex), getRow(cellIndex));
                    flowLayoutPanel.Controls.Add(newItemBox);
                }
            }
            if(parentFlowLayoutPanel0 is FlowLayoutPanel && parentFlowLayoutPanel is TableLayoutPanel)
            {
                var TablePanel = (TableLayoutPanel)parentFlowLayoutPanel;
                var flowLayoutPanel = (FlowLayoutPanel)parentFlowLayoutPanel0;

                var cellIndex = ItemBoxPanel.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;
                var cellIndex0 = ItemBoxPanel2.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;

                if(cellIndex == cellIndex0)
                {
                    TablePanel.Controls.Remove(ItemBoxPanel); // Снимаем 
                    ItemBoxPanel2.GetItemEntity.MainScript.Player.DesetItem(ItemBoxPanel.GetItemEntity);

                    flowLayoutPanel.Controls.Remove(ItemBoxPanel2); // Надеваем
                    ItemBoxPanel.GetItemEntity.MainScript.Player.SetItem(ItemBoxPanel2.GetItemEntity);

                    var newItemBox = new ItemBox(ItemBoxPanel.GetItemEntity);
                    var newItemBox0 = new ItemBox(ItemBoxPanel2.GetItemEntity) { Margin = new Padding(0) };

                    TablePanel.Controls.Add(newItemBox0, getColumn(cellIndex), getRow(cellIndex));
                    flowLayoutPanel.Controls.Add(newItemBox);
                }
            }
        }

        private void ItemBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ItemIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var control = sender as Panel;
                this.DoDragDrop(control, DragDropEffects.Move);
            }

            if (e.Button == MouseButtons.Right)
            {
                var newTag = sender as Panel;
                contextMenuStrip.Tag = newTag.Parent;
            }
        }

        private void ItemIcon_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            LinearGradientBrush gradientBrush = new LinearGradientBrush(panel.DisplayRectangle, Color.FromArgb(100, 255, 100, 0), Color.FromArgb(100, 255, 100, 0), 90F);
            Graphics g = e.Graphics;

            g.FillRectangle(gradientBrush, panel.DisplayRectangle);
        }

        private void ItemIcon_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.Paint -= ItemIcon_Paint;
            panel.Refresh();

            if (!CheckMousePosition(MultiToolTip))
            {
                MultiToolTip.Hide();
            }
        }

        private bool CheckMousePosition(MultiToolTip multiToolTip)
        {
            var startRectanglePosition = multiToolTip.Location;
            Rectangle rectangle = new Rectangle(startRectanglePosition, multiToolTip.Size);
            Region region = new Region(rectangle);
            if (region.IsVisible(Cursor.Position))
                return true;
            else
                return false;
        }

        private void ItemIcon_MouseEnter(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.Paint += ItemIcon_Paint;
            panel.Refresh();

            Point newPoint;
            if (!isVisibleChange)
                newPoint = new Point(this.Location.X + this.Size.Width - 15 + Parent.Location.X, this.Location.Y + this.Size.Height - 195 + Parent.Location.Y);
            else
                newPoint = new Point(this.Location.X + this.Size.Width - 615 + Parent.Location.X, this.Location.Y + this.Size.Height - 40 + Parent.Location.Y);
            MultiToolTip.Location = newPoint;
            MultiToolTip.Show();
        }

        private int getRow(string cellIndex)
        {
            switch (cellIndex)
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

        private int getColumn(string cellIndex)
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
    }
}
