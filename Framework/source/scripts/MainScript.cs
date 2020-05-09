using Framework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace Framework.source
{
    public class MainScript
    {
        Graphic graphic;
        scripts.world.ItemsManager ItemsManager;

        public MainScript()
        {

        }

        public MainScript SetGraphicClass(ControlCollection controls, Color c1, Color c2)
        {
            graphic = new Graphic();
            graphic.SetAllButtonsMouseEvents(controls, Color.FromArgb(150, 166, 230, 230), Color.FromArgb(150, 0, 34, 12));
            return this;
        }

        public MainScript LoadAllScripts()
        {
            ItemsManager = new scripts.world.ItemsManager();
            return this;
        }

        public List<ItemBox> GetAllItemBoxes()
        {
            List<ItemBox> ItemBoxs = new List<ItemBox>();
            int i = 0;
            foreach(var item in ItemsManager.ItemEntities)
            {
                ItemBoxs.Add(new ItemBox(item) { TabIndex = i } );
                i++;
            }
            return ItemBoxs;
        }
    }
}
