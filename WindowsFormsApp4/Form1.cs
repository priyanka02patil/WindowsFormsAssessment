using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class FormCity : Form
    {
        public FormCity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxCity.Text;

            if (!listBox.Items.Contains(name))
            {
                listBox.Items.Add(name);
            }
            else
            {
                MessageBox.Show("already exist");
            }
            
           
            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex !=-1)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
    }
}
