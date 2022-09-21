namespace ProductTracker
{
    partial class PartTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartTracker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTannerEnsignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byTannerEnsignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.version100ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.PartNumber,
            this.inStock,
            this.Price});
            this.dataTable.Location = new System.Drawing.Point(22, 68);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(495, 370);
            this.dataTable.TabIndex = 1;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 150;
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "Part Number";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.HeaderText = "In Stock";
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Part";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(423, 39);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Part(s)";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addPartToolStripMenuItem
            // 
            this.addPartToolStripMenuItem.Name = "addPartToolStripMenuItem";
            this.addPartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPartToolStripMenuItem.Text = "Add Part";
            this.addPartToolStripMenuItem.Click += new System.EventHandler(this.addPartToolStripMenuItem_Click);
            // 
            // byTannerEnsignToolStripMenuItem
            // 
            this.byTannerEnsignToolStripMenuItem.Name = "byTannerEnsignToolStripMenuItem";
            this.byTannerEnsignToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byTannerEnsignToolStripMenuItem.Text = "By Tanner Ensign";
            // 
            // version100ToolStripMenuItem
            // 
            this.version100ToolStripMenuItem.Name = "version100ToolStripMenuItem";
            this.version100ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.version100ToolStripMenuItem.Text = "Version 1.0.0";
            // 
            // deletePartsToolStripMenuItem
            // 
            this.deletePartsToolStripMenuItem.Name = "deletePartsToolStripMenuItem";
            this.deletePartsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePartsToolStripMenuItem.Text = "Delete Part(s)";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartToolStripMenuItem1,
            this.deletePartsToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byTannerEnsignToolStripMenuItem1,
            this.version100ToolStripMenuItem1});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // byTannerEnsignToolStripMenuItem1
            // 
            this.byTannerEnsignToolStripMenuItem1.Name = "byTannerEnsignToolStripMenuItem1";
            this.byTannerEnsignToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.byTannerEnsignToolStripMenuItem1.Text = "By Tanner Ensign";
            // 
            // version100ToolStripMenuItem1
            // 
            this.version100ToolStripMenuItem1.Name = "version100ToolStripMenuItem1";
            this.version100ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.version100ToolStripMenuItem1.Text = "Version 1.0.0";
            // 
            // addPartToolStripMenuItem1
            // 
            this.addPartToolStripMenuItem1.Name = "addPartToolStripMenuItem1";
            this.addPartToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addPartToolStripMenuItem1.Text = "Add Part";
            this.addPartToolStripMenuItem1.Click += new System.EventHandler(this.addPartToolStripMenuItem_Click);
            // 
            // deletePartsToolStripMenuItem1
            // 
            this.deletePartsToolStripMenuItem1.Name = "deletePartsToolStripMenuItem1";
            this.deletePartsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deletePartsToolStripMenuItem1.Text = "Delete Part(s)";
            this.deletePartsToolStripMenuItem1.Click += new System.EventHandler(this.deletePartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PartTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PartTracker";
            this.Text = "Part Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem addPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTannerEnsignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePartsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byTannerEnsignToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem version100ToolStripMenuItem1;
    }
}

