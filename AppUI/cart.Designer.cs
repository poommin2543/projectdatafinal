namespace AppUI
{
    partial class dataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cart_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.show_textBox = new System.Windows.Forms.TextBox();
            this.show_label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.TextBox();
            this.num_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "IN CART";
            // 
            // delete_button
            // 
            this.delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Location = new System.Drawing.Point(165, 4);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(67, 48);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete Select";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(524, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 59);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(85, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteallclick);
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(5, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.update_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 84);
            this.panel3.TabIndex = 9;
            // 
            // cart_dataGridView
            // 
            this.cart_dataGridView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cart_dataGridView.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.cart_dataGridView.Location = new System.Drawing.Point(0, 84);
            this.cart_dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cart_dataGridView.Name = "cart_dataGridView";
            this.cart_dataGridView.RowHeadersWidth = 51;
            this.cart_dataGridView.Size = new System.Drawing.Size(764, 313);
            this.cart_dataGridView.TabIndex = 10;
            this.cart_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cart_dataGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.show_textBox);
            this.panel2.Controls.Add(this.show_label);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.totalprice);
            this.panel2.Controls.Add(this.num_comboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.product_textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 165);
            this.panel2.TabIndex = 11;
            // 
            // show_textBox
            // 
            this.show_textBox.Location = new System.Drawing.Point(17, 33);
            this.show_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_textBox.Name = "show_textBox";
            this.show_textBox.Size = new System.Drawing.Size(35, 22);
            this.show_textBox.TabIndex = 16;
            // 
            // show_label
            // 
            this.show_label.AutoSize = true;
            this.show_label.Location = new System.Drawing.Point(12, 37);
            this.show_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show_label.Name = "show_label";
            this.show_label.Size = new System.Drawing.Size(0, 17);
            this.show_label.TabIndex = 15;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 165);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalprice
            // 
            this.totalprice.Location = new System.Drawing.Point(111, 78);
            this.totalprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(151, 22);
            this.totalprice.TabIndex = 12;
            // 
            // num_comboBox
            // 
            this.num_comboBox.FormattingEnabled = true;
            this.num_comboBox.Items.AddRange(new object[] {
            "--Select--"});
            this.num_comboBox.Location = new System.Drawing.Point(588, 30);
            this.num_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_comboBox.Name = "num_comboBox";
            this.num_comboBox.Size = new System.Drawing.Size(159, 24);
            this.num_comboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // product_textBox
            // 
            this.product_textBox.Location = new System.Drawing.Point(156, 33);
            this.product_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_textBox.Name = "product_textBox";
            this.product_textBox.Size = new System.Drawing.Size(317, 22);
            this.product_textBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 562);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 14);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(764, 576);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cart_dataGridView);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dataForm";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.dataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cart_dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox num_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label show_label;
        private System.Windows.Forms.TextBox show_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}