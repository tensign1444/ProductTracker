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

namespace ProductTracker
{
    public partial class AddPopUp : Form
    {
        /// <summary>
        /// Name of Part being added
        /// </summary>
        public string PartName
        {
            get { return partNameTextbox.Text; }
        }

        /// <summary>
        /// Price of Part being Added
        /// </summary>
        public string PartPrice
        {
            get { return partPriceTextBox.Text; }
        }

        /// <summary>
        /// InStock variable
        /// </summary>
        public string InStock
        {
            get { return inStockBox.Value.ToString(); }
        }

        /// <summary>
        /// Part Sku variable
        /// </summary>
        public string PartSku
        {
            get { return partSkuTextbox.Text; }
        }

        /// <summary>
        /// Constructor for the pop up window
        /// </summary>
        public AddPopUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancel button click on popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
