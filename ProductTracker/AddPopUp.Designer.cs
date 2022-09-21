namespace ProductTracker
{
    partial class AddPopUp
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
            this.partNameTextbox = new System.Windows.Forms.TextBox();
            this.partSkuTextbox = new System.Windows.Forms.TextBox();
            this.inStockBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.partSkuLabel = new System.Windows.Forms.Label();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inStockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // partNameTextbox
            // 
            this.partNameTextbox.Location = new System.Drawing.Point(89, 26);
            this.partNameTextbox.Name = "partNameTextbox";
            this.partNameTextbox.Size = new System.Drawing.Size(120, 20);
            this.partNameTextbox.TabIndex = 0;
            // 
            // partSkuTextbox
            // 
            this.partSkuTextbox.Location = new System.Drawing.Point(89, 52);
            this.partSkuTextbox.Name = "partSkuTextbox";
            this.partSkuTextbox.Size = new System.Drawing.Size(120, 20);
            this.partSkuTextbox.TabIndex = 1;
            // 
            // inStockBox
            // 
            this.inStockBox.Location = new System.Drawing.Point(89, 78);
            this.inStockBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inStockBox.Name = "inStockBox";
            this.inStockBox.Size = new System.Drawing.Size(120, 20);
            this.inStockBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part Name:";
            // 
            // partSkuLabel
            // 
            this.partSkuLabel.AutoSize = true;
            this.partSkuLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSkuLabel.Location = new System.Drawing.Point(16, 53);
            this.partSkuLabel.Name = "partSkuLabel";
            this.partSkuLabel.Size = new System.Drawing.Size(60, 19);
            this.partSkuLabel.TabIndex = 5;
            this.partSkuLabel.Text = "Part SKU:";
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockLabel.Location = new System.Drawing.Point(22, 79);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(54, 19);
            this.inStockLabel.TabIndex = 6;
            this.inStockLabel.Text = "In Stock:";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPriceLabel.Location = new System.Drawing.Point(12, 105);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(64, 19);
            this.partPriceLabel.TabIndex = 7;
            this.partPriceLabel.Text = "Part Price:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 137);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(134, 137);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(89, 104);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(120, 20);
            this.partPriceTextBox.TabIndex = 10;
            this.partPriceTextBox.Text = "$";
            // 
            // AddPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 172);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.inStockLabel);
            this.Controls.Add(this.partSkuLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inStockBox);
            this.Controls.Add(this.partSkuTextbox);
            this.Controls.Add(this.partNameTextbox);
            this.Name = "AddPopUp";
            this.Text = "Add Part";
            ((System.ComponentModel.ISupportInitialize)(this.inStockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partNameTextbox;
        private System.Windows.Forms.TextBox partSkuTextbox;
        private System.Windows.Forms.NumericUpDown inStockBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partSkuLabel;
        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox partPriceTextBox;
    }
}