using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Controllers
{
    public static class ListBoxController
    {

        public static ListBox AddProductAsItem(ref ListBox listbox, string productName)
        {
            listbox.Items.Add(productName);
            return listbox;
        }

        public static ListBox AddProductParameters(ref ListBox listbox, int quantity, double prPrice, double dlPrice)
        {
            listbox.Items.Add(quantity + " " + prPrice + " " + dlPrice);
            return listbox;
        }

    }
}
