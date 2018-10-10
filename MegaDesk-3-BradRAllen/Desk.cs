using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradRAllen
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }
        public string SurfaceMaterial { get; set; }

        #region contants
        //desk retraints
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int DEPTH_MIN = 12;
        public const int DEPTH_MAX = 48;
        #endregion
    }
}
