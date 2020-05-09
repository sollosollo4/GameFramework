using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.Controls
{
    public partial class UserPanel : Panel
    {
        public UserPanel(string text)
        {
            InitializeComponent();
            Size = BackgroundImage.Size;
            Controls.Add(new Label()
            {
                Location = new Point(28, 28),
                AutoSize = false,
                Size = new Size(Size.Width - 55, Size.Height - 55),
                TabStop = false,
                Text = text,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            });

            Button newButton = new Button()
            {
                Text = "Закрыть",
                Dock = DockStyle.Bottom,
            };
            newButton.Click += UserPanel_Click;
            Controls.Add(newButton);
        }

        private void UserPanel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
    
}
