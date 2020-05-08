using Framework;
using Framework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public partial class MainMenu : Form
    {
        int tickCount;

        public MainMenu()
        {
            InitializeComponent();

            SetDefaultParametrs();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Functions.Graphic graphic = new Functions.Graphic();
            graphic.SetAllButtonsMouseEvents(MainMenuPanel.Controls, Color.FromArgb(150, 166, 230, 230), Color.FromArgb(150, 0, 34, 12));
        }

        private void SetDefaultParametrs()
        {
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;

            GradientLabel gradientLabel = new GradientLabel(Color.Red, Color.Blue, 25, "Разработчик: sollosollo4") { 
                Location = new Point(12, 832), 
                BackColor = Color.Transparent, 
                AutoSize = false, 
                Size = new Size(217, 23), 
                Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204) 
                }; 
            Controls.Add(gradientLabel);
        }
        

        private void MainMenuButton_CloseGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenuButton_Settings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
        }

        private void MainMenuButton_ContinueGame_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_NewGame_Click(object sender, EventArgs e)
        {
            Forms.Game game = new Forms.Game();
            Hide();
            game.ShowDialog();
        }

        private void GradientChange_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount >= 6)
                tickCount = 0;
        }

        public static Color Rainbow(float progress)
        {
            float div = (Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default: // case 5:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }
    }
}
