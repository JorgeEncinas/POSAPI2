using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAPI2
{
    public static class LayUtil
    {

        public static void centerElementAtY(Control parent, Control child, double parentPercentage, double childPercentage)
        {
            child.Location = new Point(Convert.ToInt32(parent.Width / 2 - child.Width / 2),
                    Convert.ToInt32((parent.Height * parentPercentage) - (child.Height * childPercentage)));
        }

        public static void placeOnSuperior(Control superior, Control inferior, double sPercentageX, double iPercentageX, double sPercentageY, double iPercentageY)
        {
            inferior.Location = new Point(
                    Convert.ToInt32((superior.Width * sPercentageX) - (inferior.Width * iPercentageX)),
                    Convert.ToInt32((superior.Height * sPercentageY) - (inferior.Height * iPercentageY)));
        }

        public static void sizeToSuperior(Control superior, Control inferior, double percentageX, double percentageY)
        {
            inferior.Size = new Size(Convert.ToInt32(superior.Width * percentageX),
                                     Convert.ToInt32(superior.Height * percentageY));
        }

    }
}
