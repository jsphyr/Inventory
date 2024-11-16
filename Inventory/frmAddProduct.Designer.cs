
namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(142, 62);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(379, 27);
            txtProductName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(142, 237);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(379, 27);
            txtQuantity.TabIndex = 3;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(142, 281);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(379, 27);
            txtSellPrice.TabIndex = 4;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(142, 105);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(379, 28);
            cbCategory.TabIndex = 5;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(142, 144);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(379, 27);
            dtPickerMfgDate.TabIndex = 6;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(142, 191);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(379, 27);
            dtPickerExpDate.TabIndex = 7;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(566, 87);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(461, 221);
            richTxtDescription.TabIndex = 8;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 353);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersWidth = 51;
            gridViewProductList.Size = new Size(1015, 242);
            gridViewProductList.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(892, 314);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 10;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 11;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 12;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 13;
            label3.Text = "Mfg. Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 14;
            label4.Text = "Exp. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 15;
            label5.Text = "Qty.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 16;
            label6.Text = "Sell Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(566, 62);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 17;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(155, 35);
            label8.TabIndex = 18;
            label8.Text = "Add Product";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 607);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
