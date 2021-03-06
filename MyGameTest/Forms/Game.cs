﻿using Framework.Controls;
using Framework.source;
using Framework.source.scripts.world;
using SharpGL;
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

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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

            script.AspectsLabel = new Label[5];
            script.AspectsLabel[0] = FireLabel;
            script.AspectsLabel[1] = IceLabel;
            script.AspectsLabel[2] = NatureLabel;
            script.AspectsLabel[3] = LigthLabel;
            script.AspectsLabel[4] = DarkLabel;

            script.DmgInfolabel = new Label[2];
            script.DmgInfolabel[0] = MagDmg;
            script.DmgInfolabel[1] = PhysDmg;

            Graphic g = new Graphic();
            g.SetAllPictureBoxMouseEvents(MainInterface.Controls, Color.FromArgb(35, 100, 20, 100), Color.FromArgb(35, 100, 20, 100));

            OpenGL gl = openGLControl.
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

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Keys keys = Control.ModifierKeys;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Close();
        }

        private void HeroIcon_Click(object sender, EventArgs e)
        {
            MainHeroInterface_BackGround.Visible = !MainHeroInterface_BackGround.Visible;
        }

        private void BackPackIcon_Click(object sender, EventArgs e)
        {
            BackPackInterface_BackGround.Visible = !BackPackInterface_BackGround.Visible;
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

        private void BackPackInterface_MouseEnter(object sender, EventArgs e)
        {

        }

        private void BackPackInterface_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void BackPackInterface_DragDrop(object sender, DragEventArgs e)
        {
            var pol = (FlowLayoutPanel)sender; // на кого
            var objectToDrag = (Panel)e.Data.GetData(typeof(Panel)); // кто
            
            var ItemBoxPanel = (ItemBox)objectToDrag.Parent; // кто
            Control parentFlowLayoutPanel0 = ItemBoxPanel.Parent; // родитель панель с которой кидаем

            if (parentFlowLayoutPanel0 is TableLayoutPanel && pol is FlowLayoutPanel)
            {
                var TablePanel = (TableLayoutPanel)parentFlowLayoutPanel0;
                TablePanel.Controls.Remove(ItemBoxPanel);

                script.Player.DesetItem(ItemBoxPanel.GetItemEntity);
                ItemBox itemBox = new ItemBox(ItemBoxPanel.GetItemEntity);
                pol.Controls.Add(itemBox);

                var cellIndex = ItemBoxPanel.GetItemEntity.StringableCharacters.FirstOrDefault(x => x.CharacterName == ItemCharacter<string>.CharacterNames[(int)ItemCharacter<string>.CharacterNamesT.EquipType]).CharacterValue;
                PictureBox pictureBox = new PictureBox()
                {
                    Image = ItemBoxPanel.GetItemEntity.MainScript.getImage(cellIndex),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Margin = new Padding(0),
                    Dock = DockStyle.Fill
                };
                TablePanel.Controls.Add(pictureBox, script.getColumn(cellIndex), script.getRow(cellIndex));
            }
        }
    }
}
