using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            listBoxkoleksi.Items.Add(textBoxinput.Text);
        }

        private void listBoxkoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelhalo.Text = listBoxkoleksi.SelectedItem.ToString();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonwarnamerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked == true)
            {
                if (radioButtonwarnamerah.Checked == true)
                {
                    labelhalo.ForeColor = Color.Red;
                }
                else if (radioButtonwarnabiru.Checked == true)
                {
                    labelhalo.ForeColor = Color.Blue;
                }
            }
            else
            {
                labelhalo.ForeColor = Color.Black;
            }
        }

        private void radioButtonwarnabiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked == true)
            {
                if (radioButtonwarnamerah.Checked == true)
                {
                    labelhalo.ForeColor = Color.Red;
                }
                else if (radioButtonwarnabiru.Checked == true)
                {
                    labelhalo.ForeColor = Color.Blue;
                }
            }
            else
            {
                labelhalo.ForeColor = Color.Black;
            }

        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked == true)
            {
                if (radioButtonwarnamerah.Checked == true)
                {
                    labelhalo.ForeColor = Color.Red;
                }
                else if (radioButtonwarnabiru.Checked == true)
                {
                    labelhalo.ForeColor = Color.Blue;
                }
            }
            else
            {
                labelhalo.ForeColor = Color.Black;
            }
        }
    }
}
