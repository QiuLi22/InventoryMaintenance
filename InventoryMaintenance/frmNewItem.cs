using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        InvItem item = null;
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.

        // Add a method here that gets and returns a new item.

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                item = new InvItem(Convert.ToInt32(txtItemNo.Text), 
                    txtDescription.Text,
                    Convert.ToDecimal(txtPrice.Text));
                // and closes the form.
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return item;
        }
    }
}
