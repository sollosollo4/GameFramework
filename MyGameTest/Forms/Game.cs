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
        public Game(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            InitializeComponent();

            SetDefaultParametrs();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void SetDefaultParametrs()
        {
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Close();
        }

        private void HeroIcon_Click(object sender, EventArgs e)
        {

        }

        private void BackPackIcon_Click(object sender, EventArgs e)
        {

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
    }
}
