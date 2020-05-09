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

            this.MouseDown += ItemBox_MouseDown;
            ItemIcon.MouseDown += ItemIcon_MouseDown;

            this.DragEnter += ItemBox_DragEnter;
            this.DragDrop += ItemBox_DragDrop;
            ItemIcon.DragEnter += ItemBox_DragEnter;
            ItemIcon.DragDrop += ItemIcon_DragDrop;

            Controls.Add(ItemIcon);

            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Надеть", null, UseItemBoxContextStrip);
            contextMenuStrip.Items.Add("Удалить", null, DeleteItemBoxContextStrip);
            this.ContextMenuStrip = contextMenuStrip;
            


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

        private void UseItemBoxContextStrip(object sender, EventArgs e)
        {

        }

        private void ItemIcon_DragDrop(object sender, DragEventArgs e)
        {
            var pol = (Panel)sender;

            var objectToDrag = (Panel)e.Data.GetData(typeof(Panel));

            var parentFlowLayutPanel = (FlowLayoutPanel)pol.Parent.Parent;
            int newIndex = 0;

            if(objectToDrag != null)
                newIndex = parentFlowLayutPanel.Controls.IndexOf(objectToDrag);
            else
            {
                var newObjectToDrag = (ItemBox)e.Data.GetData(typeof(ItemBox));
                newIndex = parentFlowLayutPanel.Controls.IndexOf(newObjectToDrag);
            }

            parentFlowLayutPanel.Controls.SetChildIndex(pol.Parent, newIndex);
        }

        private void ItemBox_DragDrop(object sender, DragEventArgs e)
        {
            var pol = (ItemBox)sender;

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
                ItemBox_MouseDown(control.Parent, e);
            }

            if (e.Button == MouseButtons.Right)
            {
                var newTag = sender as Panel;
                contextMenuStrip.Tag = newTag.Parent;
            }
        }

        private void ItemBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var control = sender as ItemBox;
                this.DoDragDrop(control, DragDropEffects.Move);
            }

            if (e.Button == MouseButtons.Right)
            {
                var tags = sender as ItemBox;
                contextMenuStrip.Tag = tags;
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
            

            Point newPoint = new Point(this.Location.X + this.Size.Width - 15 + Parent.Location.X, this.Location.Y + this.Size.Height - 195 + Parent.Location.Y);
            MultiToolTip.Location = newPoint;
            MultiToolTip.Show();
        }
    }
}
