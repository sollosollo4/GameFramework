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
        public Game()
        {
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
    }
}
