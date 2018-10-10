using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradRAllen
{
    class DeskQoute
    {
        #region member variables
        //parts of the desk quote
        private string CustomerName;
        private DateTime Quotedate;
        private Desk Desk = new Desk();

        #endregion

        

        public DeskQoute(int width, int depth, int drawers, string material, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumOfDrawers = drawers;

        }

        public int CalculateQuoteTotal()
        {
            return 1;
        }
    }
}
