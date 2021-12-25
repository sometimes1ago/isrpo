using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingPool
{
    class Service
    {
        public void CleanTextControl(List<Control> ControlsList)
        {
            foreach (Control Item in ControlsList)
            {
                Item.Text = "";
            }
        }

        public string[] SplitComboboxItem(ComboBox Item, char Splitter)
        {
            string SelectedString = Item.SelectedItem.ToString();
            string[] SplStrArr = SelectedString.Split(Splitter);
            return SplStrArr;
        }
    }
}
