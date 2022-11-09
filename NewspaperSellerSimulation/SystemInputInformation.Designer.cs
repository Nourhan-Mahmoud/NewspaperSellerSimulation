namespace NewspaperSellerSimulation
{
    partial class SystemInputInformation
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
            this.NumOfNewspapers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfRecords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PurchasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ScrapPrice = new System.Windows.Forms.TextBox();
            this.SellingPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumOfNewspapers
            // 
            this.NumOfNewspapers.Location = new System.Drawing.Point(290, 94);
            this.NumOfNewspapers.Name = "NumOfNewspapers";
            this.NumOfNewspapers.Size = new System.Drawing.Size(100, 22);
            this.NumOfNewspapers.TabIndex = 0;
            this.NumOfNewspapers.TextChanged += new System.EventHandler(this.NumOfNewspapers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Input Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num Of Newspapers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num Of Records";
            // 
            // NumOfRecords
            // 
            this.NumOfRecords.Location = new System.Drawing.Point(290, 135);
            this.NumOfRecords.Name = "NumOfRecords";
            this.NumOfRecords.Size = new System.Drawing.Size(100, 22);
            this.NumOfRecords.TabIndex = 4;
            this.NumOfRecords.TextChanged += new System.EventHandler(this.NumOfRecords_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Purchase Price";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Location = new System.Drawing.Point(290, 178);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(100, 22);
            this.PurchasePrice.TabIndex = 6;
            this.PurchasePrice.TextChanged += new System.EventHandler(this.PurchasePrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Scrap Price";
            // 
            // ScrapPrice
            // 
            this.ScrapPrice.Location = new System.Drawing.Point(290, 225);
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(100, 22);
            this.ScrapPrice.TabIndex = 8;
            this.ScrapPrice.TextChanged += new System.EventHandler(this.ScrapPrice_TextChanged);
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSize = true;
            this.SellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrice.Location = new System.Drawing.Point(14, 263);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(163, 29);
            this.SellingPrice.TabIndex = 9;
            this.SellingPrice.Text = "Selling Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 375);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 155);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Table 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Table 2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(487, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(397, 315);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SystemInputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfNewspapers);
            this.Name = "SystemInputInformation";
            this.Text = "System Input Information";
            this.Load += new System.EventHandler(this.SystemInputInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumOfNewspapers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumOfRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PurchasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ScrapPrice;
        private System.Windows.Forms.Label SellingPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}