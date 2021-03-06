﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Framework.source
{
    public class Graphic
    {
        private Color color1;
        private Color color2;

        public void SetAllButtonsMouseEvents(ControlCollection controls, Color c1, Color c2)
        {
            foreach (var button in controls)
            {
                var but = button as Button;
                if (but == null)
                {
                    throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является Button, из за чего вызов метода SetAllButtonsMouseEvents невозможен");
                }

                int countVs = controls.Count;
                color1 = c1;
                color2 = c2;
                    
                but.MouseEnter += But_MouseEnter;
                but.MouseLeave += But_MouseLeave;
            }
        }

        private void But_Paint(object sender, PaintEventArgs e)
        {
            var button = sender as Button;
            if (button == null && button.Tag is true)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является Button, из за чего вызов метода SetAllButtonsMouseEvents невозможен");
            }

            LinearGradientBrush gradientBrush = new LinearGradientBrush(button.DisplayRectangle, color1, color2, 90F);
            Graphics g = e.Graphics;

            g.FillRectangle(gradientBrush, button.DisplayRectangle);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString(button.Text, button.Font, Brushes.Black, button.ClientRectangle, format);     
        }

        private void But_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является Button, из за чего вызов метода SetAllButtonsMouseEvents невозможен");
            }

            button.Paint -= But_Paint;
            button.Refresh();
        }
            
        private void But_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является Button, из за чего вызов метода SetAllButtonsMouseEvents невозможен");
            }

            button.Paint += But_Paint;
            button.Refresh();
        }


        public void SetAllPictureBoxMouseEvents(ControlCollection controls, Color c1, Color c2)
        {
            foreach (var button in controls)
            {
                var but = button as PictureBox;
                if (but == null)
                {
                    throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является PictureBox, из за чего вызов метода SetAllPictureBoxMuseEvents невозможен");
                }

                int countVs = controls.Count;
                color1 = c1;
                color2 = c2;

                but.MouseEnter += Pb_MouseEnter;
                but.MouseLeave += Pb_MouseLeave;
            }
        }

        private void Pb_MouseLeave(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является PictureBox, из за чего вызов метода SetAllPictureBoxMuseEvents невозможен");
            }

            pb.Paint -= pb_Paint;
            pb.Refresh();
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null && pb.Tag is true)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является Button, из за чего вызов метода SetAllPictureBoxMuseEvents невозможен");
            }

            LinearGradientBrush gradientBrush = new LinearGradientBrush(pb.DisplayRectangle, color1, color2, 90F);
            Graphics g = e.Graphics;

            g.FillRectangle(gradientBrush, pb.DisplayRectangle);
        }

        private void Pb_MouseEnter(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null)
            {
                throw new Exception("Один из элементов коллекции ControlCollection в главном меню игры не является PictureBox, из за чего вызов метода SetAllPictureBoxMuseEvents невозможен");
            }

            pb.Paint += pb_Paint;
            pb.Refresh();
        }
    }
}
