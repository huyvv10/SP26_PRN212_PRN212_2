namespace WinFormsApp1
{
    partial class frmMain
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnSum = new Button();
            btnSub = new Button();
            btnProduct = new Button();
            btnQuotien = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 94);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 148);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = Color.FromArgb(255, 192, 192);
            txtNum1.Font = new Font("Segoe UI", 13.8F);
            txtNum1.Location = new Point(134, 30);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(482, 38);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.FromArgb(255, 192, 192);
            txtNum2.Font = new Font("Segoe UI", 13.8F);
            txtNum2.Location = new Point(134, 82);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(482, 38);
            txtNum2.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(255, 192, 192);
            txtResult.Font = new Font("Segoe UI", 13.8F);
            txtResult.Location = new Point(134, 136);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(482, 38);
            txtResult.TabIndex = 5;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.FromArgb(255, 255, 128);
            btnSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSum.ForeColor = Color.Blue;
            btnSum.Location = new Point(33, 213);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(125, 41);
            btnSum.TabIndex = 6;
            btnSum.Text = "&Sum";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(255, 255, 128);
            btnSub.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSub.ForeColor = Color.Blue;
            btnSub.Location = new Point(168, 213);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(125, 41);
            btnSub.TabIndex = 7;
            btnSub.Text = "S&ubstract";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(255, 255, 128);
            btnProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnProduct.ForeColor = Color.Blue;
            btnProduct.Location = new Point(303, 213);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(125, 41);
            btnProduct.TabIndex = 8;
            btnProduct.Text = "&Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnQuotien
            // 
            btnQuotien.BackColor = Color.FromArgb(255, 255, 128);
            btnQuotien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnQuotien.ForeColor = Color.Blue;
            btnQuotien.Location = new Point(438, 213);
            btnQuotien.Name = "btnQuotien";
            btnQuotien.Size = new Size(125, 41);
            btnQuotien.TabIndex = 9;
            btnQuotien.Text = "&Quotien";
            btnQuotien.UseVisualStyleBackColor = false;
            btnQuotien.Click += btnQuotien_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 255, 128);
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClose.ForeColor = Color.Blue;
            btnClose.Location = new Point(573, 213);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 41);
            btnClose.TabIndex = 10;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(728, 297);
            Controls.Add(btnClose);
            Controls.Add(btnQuotien);
            Controls.Add(btnProduct);
            Controls.Add(btnSub);
            Controls.Add(btnSum);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan ly sinh vien";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnSum;
        private Button btnSub;
        private Button btnProduct;
        private Button btnQuotien;
        private Button btnClose;
    }
}
