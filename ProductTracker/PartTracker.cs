using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ProductTracker
{
    public partial class PartTracker : Form
    {
        Parts parts;
        public PartTracker()
        {
            parts = new Parts("ITT");
            
            InitializeComponent();          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Delete menu bar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// Delete Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// Physical Add button on form click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        /// <summary>
        /// Menu bar, edit, add part button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }


        //__________________________________Helper Methods__________________________

        /// <summary>
        /// Adds item to memory database and table
        /// </summary>
        private void Add()
        {
            string partName = "";
            string PartPrice = "";
            string InStock = "";
            string PartSku = "";
            var popUp = new AddPopUp();
            popUp.ShowDialog(this); // make sure this instance of Form1 is visible

            partName = popUp.PartName;
            PartPrice = popUp.PartPrice;
            InStock = popUp.InStock;
            PartSku = popUp.PartSku;

            parts.AddPart(partName, PartSku, PartPrice, InStock); 

            dataTable.Rows.Add(partName, PartSku,InStock, PartPrice);
        }

        /// <summary>
        /// Deletes selected items from data table
        /// </summary>
        private void Delete()
        {
            foreach (DataGridViewRow item in this.dataTable.SelectedRows)
            {
                dataTable.Rows.RemoveAt(item.Index);
            }
        }


    }
}
