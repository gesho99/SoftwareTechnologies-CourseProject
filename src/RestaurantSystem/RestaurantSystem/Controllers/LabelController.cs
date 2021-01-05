using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Controllers
{
    public static class LabelController
    {
        public static bool ChangeLabelVisibility(ref Label label, bool visibility)
        {
            label.Visible = visibility;
            return label.Visible;
        }

        public static string ChangeLabelText(ref Label label, String text)
        {
            label.Text = text;
            return label.Text;
        }

    }
}
