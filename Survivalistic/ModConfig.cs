using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Survivalistic
{
    class ModConfig
    {
        public string Language { get; set; }
        public string Position { get; set; }
        public int CustomPositionX { get; set; }
        public int CustomPositionY { get; set; }
        public Color HungerBarColor { get; set; }
        public Color HungerSaturationColor { get; set; }
        public Color ThirstBarColor { get; set; }
        public Color ThirstSaturationColor { get; set; }
    }
}
