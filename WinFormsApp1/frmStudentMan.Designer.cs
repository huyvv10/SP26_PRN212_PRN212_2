namespace WinFormsApp1
{
    partial class frmStudentMan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(954, 41);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MANAGEMENT";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 165);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 214);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(170, 215);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(320, 212);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 27);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 264);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 10;
            label6.Text = "Addresss";
            // 
            // frmStudentMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 454);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentMan";
            Text = "frmStudentMan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox3;
        private Label label6;
    }
}