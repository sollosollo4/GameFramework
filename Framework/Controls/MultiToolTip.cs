using Framework.source.scripts.world;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.Controls
{
    public partial class MultiToolTip : Form
    {
        public MultiToolTip()
        {
            InitializeComponent();
        }

        public MultiToolTip(ItemEntity item)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, item.ItemName.QualityColor);

            ItemName.Text = item.ItemName.Name;
            ToolTip.ForeColor = Color.FromArgb(90, item.ItemName.QualityColor);

            DamageLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Damage]).CharacterValue.ToString(); 
            
            AgilityLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Agility]).CharacterValue.ToString();

            ForceLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Force]).CharacterValue.ToString();

            IntellectLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.Intellect]).CharacterValue.ToString();

            FireLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.FireM]).CharacterValue.ToString();

            IceLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.IceM]).CharacterValue.ToString();

            NatureLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.NatureM]).CharacterValue.ToString();

            LigthLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.LigthM]).CharacterValue.ToString();

            DarkLabel.Text = item.IntableCharacters.SingleOrDefault(x => x.CharacterName ==
                ItemCharacter<int>.CharacterNames[(int)ItemCharacter<int>.CharacterNamesT.DarkM]).CharacterValue.ToString();
        }

        private void ToolTip_MouseLeave(object sender, EventArgs e)
        {
            if(!CheckMousePosition(this))
                Hide();
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

        private void ToolTip_MouseMove(object sender, MouseEventArgs e)
        {
            if (!CheckMousePosition(this))
                Hide();
        }
    }
}
