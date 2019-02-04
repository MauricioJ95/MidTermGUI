using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMidTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (CheckForSelectedItem(lbProducts))
            {
                lbCart.Items.Add(lbProducts.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbProducts_DoubleClick(object sender, EventArgs e)
        {
            lblError.Text = "";

            lbCart.Items.Add(lbProducts.SelectedItem);
        }

        private void lbCart_DoubleClick(object sender, EventArgs e)
        {
            lblError.Text = "";

            lbCart.Items.Remove(lbCart.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (CheckForSelectedItem(lbCart))
            {
                lbCart.Items.Remove(lbCart.SelectedItem);
            }
        }

        private bool CheckForSelectedItem(ListBox lb)
        {
            lblError.Text = "";

            if (lb.SelectedItem == null)
            {
                lblError.Text = "Please select an item";

                return false;
            }

            return true;
        }
    }
}
