using Framework.Controls;
using Framework.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework.Forms
{
    public partial class Game : Form
    {
        private readonly MainMenu mainMenu;
        private readonly MainScript script;
        public Game(MainMenu mainMenu, MainScript script)
        {
            this.mainMenu = mainMenu;
            this.script = script;
            InitializeComponent();

            SetDefaultParametrs();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            VisibleFirstWindow();
        }

        private void VisibleFirstWindow()
        {
            UserPanel userPanel = new UserPanel("Привет, странствующий путешественник!");
            userPanel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - userPanel.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - userPanel.Height / 2);
            BackGround.Controls.Add(userPanel);
        }

        private void SetDefaultParametrs()
        {
            KeyPreview = true;
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;

            script.BackPackInterfacePanel = BackPackInterface;

            script.HeroInterfacePanel = MainHeroInterface;

            script.AFILabels = new Label[3];
            script.AFILabels[0] = ForceLabel;
            script.AFILabels[1] = AgilityLabel;
            script.AFILabels[2] = IntellectLabel;

            Graphic g = new Graphic();
            g.SetAllPictureBoxMouseEvents(MainInterface.Controls, Color.FromArgb(35, 100, 20, 100), Color.FromArgb(35, 100, 20, 100));
        }

        private void Game_Load(object sender, EventArgs e)
        {
            BackPackInterface.Controls.AddRange(script.GetAllItemBoxes().ToArray());
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = Control.ModifierKeys;
            if (keys == Keys.Shift)
            {
                if(e.KeyCode == Keys.B)
                {
                    BackPackIcon_Click(sender, e);
                }
            }

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if(e.KeyCode == Keys.C)
            {
                HeroIcon_Click(sender, e);
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Close();
        }

        private void HeroIcon_Click(object sender, EventArgs e)
        {
            MainHeroInterface.Visible = !MainHeroInterface.Visible;
            MainHeroInterfaceBackground.Visible = !MainHeroInterfaceBackground.Visible;
        }

        private void BackPackIcon_Click(object sender, EventArgs e)
        {
            BackPackInterface.Visible = !BackPackInterface.Visible;
            BackPackInterfaceBackGround.Visible = !BackPackInterfaceBackGround.Visible;
        }

        private void Achivments_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Skills_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Map_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Guild_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Talking_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Icon_Click(object sender, EventArgs e)
        {

        }

        private void MainHeroInterface_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
