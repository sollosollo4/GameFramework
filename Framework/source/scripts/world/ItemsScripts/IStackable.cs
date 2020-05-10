using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.source.scripts.world.ItemsScripts
{
    interface IStackable
    {
        int Count { get; set; }
        int MaxCount { get; set; }
    }
}
