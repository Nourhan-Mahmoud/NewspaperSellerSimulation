namespace NewspaperSellerSimulation
{
    partial class HomePage
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
            this.testCase1 = new System.Windows.Forms.Button();
            this.testCase2 = new System.Windows.Forms.Button();
            this.testCase3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose TestCase :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // testCase1
            // 
            this.testCase1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCase1.Location = new System.Drawing.Point(62, 332);
            this.testCase1.Name = "testCase1";
            this.testCase1.Size = new System.Drawing.Size(265, 76);
            this.testCase1.TabIndex = 4;
            this.testCase1.Text = "Run TestCase 1";
            this.testCase1.UseVisualStyleBackColor = false;
            this.testCase1.Click += new System.EventHandler(this.testCase1_Click);
            // 
            // testCase2
            // 
            this.testCase2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCase2.Location = new System.Drawing.Point(423, 332);
            this.testCase2.Name = "testCase2";
            this.testCase2.Size = new System.Drawing.Size(265, 76);
            this.testCase2.TabIndex = 5;
            this.testCase2.Text = "Run TestCase 2";
            this.testCase2.UseVisualStyleBackColor = false;
            this.testCase2.Click += new System.EventHandler(this.testCase2_Click);
            // 
            // testCase3
            // 
            this.testCase3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testCase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCase3.Location = new System.Drawing.Point(791, 332);
            this.testCase3.Name = "testCase3";
            this.testCase3.Size = new System.Drawing.Size(265, 76);
            this.testCase3.TabIndex = 6;
            this.testCase3.Text = "Run TestCase 3";
            this.testCase3.UseVisualStyleBackColor = false;
            this.testCase3.Click += new System.EventHandler(this.testCase3_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NewspaperSellerSimulation.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1122, 493);
            this.Controls.Add(this.testCase3);
            this.Controls.Add(this.testCase2);
            this.Controls.Add(this.testCase1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testCase1;
        private System.Windows.Forms.Button testCase2;
        private System.Windows.Forms.Button testCase3;
    }
}