using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Controllers
{
    public static class ListBoxController
    {

        public static ListBox AddListBoxItems(ref ListBox listbox, string productName)
        {
            listbox.Items.Add(productName);
            return listbox;
        }

        public static ListBox AddListBoxParameters(ref ListBox listbox, int quantity, double prPrice, double dlPrice)
        {
            listbox.Items.Add(quantity + " " + prPrice + " " + dlPrice);
            return listbox;
        }

        public static ListBox AddListBoxParameters(ref ListBox listbox, double dishPrice, string products, double dishWeight)
        {
            listbox.Items.Add(dishPrice + " " + products + dishWeight);
            return listbox;
        }

        public static ListBox ClearItems(ref ListBox listbox)
        {
            listbox.Items.Clear();
            return listbox;
        }

    }
}
