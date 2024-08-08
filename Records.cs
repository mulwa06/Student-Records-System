using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part2_Task2_
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void buttonSUBMIT_Click(object sender, EventArgs e)
        {
            var modulename = maskedTextBoxMODULE.Text;
            var marks = textBoxMARKS.Text;

            // validates if Marks entered are integers
            try
            {
                Module module = new Module()
                {
                    Name = modulename,
                    Marks = int.Parse(marks)
                };
                // add the item to listview
                ListViewItem listViewItem = new ListViewItem(module.Name);
                listViewItem.SubItems.Add(module.Marks.ToString());
                listViewMODULES.Items.Add(listViewItem);
            }
            catch
            {
                MessageBox.Show("The marks you entered wasn't of type integers");
            }
        }

        private void buttonAVERAGE_Click_1(object sender, EventArgs e)
        {
            var total = 0;

            // loop through each sub item and accumalate total
            foreach (ListViewItem item in listViewMODULES.Items)
            {
                var subitem = item.SubItems[1];
                total += int.Parse(subitem.Text);
            }

            // calculate average
            var average = total / listViewMODULES.Items.Count;

            // display average
            labelAVERAGE.Text = average.ToString();
        }

        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewMODULES.Items)
            {
                if (item.SubItems.Count > 1) // Ensure there is a second subitem
                {
                    item.SubItems[1].Text = string.Empty; // Clear the value in the second column
                }
            }
        }
    }
}
