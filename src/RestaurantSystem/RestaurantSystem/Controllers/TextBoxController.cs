using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Controllers
{
    public static class TextBoxController
    {

        public static string ChangeTextBoxText(ref TextBox tb1, string newText)
        {
            tb1.Text = newText;
            return newText;
        }

        public static string[] ChangeThreeTextBoxesText(ref TextBox tb1, ref TextBox tb2, ref TextBox tb3, string newText1, string newText2, string newText3)
        {
            tb1.Text = newText1;
            tb2.Text = newText2;
            tb3.Text = newText3;

            string[] newTextes = new string[] { newText1, newText2, newText3 };

            return newTextes;
        }

    }
}
