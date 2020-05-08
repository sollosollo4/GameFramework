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
    public partial class GradientLabel : Label
    {
        string text;
        static int count = 1;
        float angle = 0;
        Color color1;
        Color color2;

        public GradientLabel(Color clr1, Color clr2, float angle, string text)
        {
            this.color1 = clr1;
            this.color2 = clr2;
            this.angle = angle;
            this.text = text;
            this.Paint += new PaintEventHandler(GradientLabel_Paint);
        }

        void GradientLabel_Paint(object sender, PaintEventArgs e)
        {
            float width = e.Graphics.MeasureString(this.Text, this.Font).Width;
            float height = e.Graphics.MeasureString(this.Text, this.Font).Height;
            LinearGradientBrush brush = new LinearGradientBrush(new RectangleF(0F, 0F, width, height), color1, color2, angle, true);
            e.Graphics.DrawString(text, this.Font, brush, new PointF(0F, 0F));
        }

        /// <summary>
        /// Первый цвет градиента
        /// </summary>
        public Color Color1
        {
            get
            {
                return color1;
            }
            set
            {
                color1 = value;
            }
        }

        /// <summary>
        /// Второй цвет градианта
        /// </summary>
        public Color Color2
        {
            get
            {
                return color2;
            }
            set
            {
                color2 = value;
            }
        }

        /// <summary>
        /// Угол градиента
        /// </summary>
        public float Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }

        /// <summary>
        /// Текст
        /// </summary>
        new public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        
    }
}
