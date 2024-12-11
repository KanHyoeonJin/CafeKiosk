namespace CafeKiosk
{
    partial class Form7
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            lb_price = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            sirupNumber = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sirupNumber).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_price);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sirupNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(429, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "옵션";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new System.Drawing.Point(60, 302);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(22, 25);
            lb_price.TabIndex = 13;
            lb_price.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 302);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 25);
            label3.TabIndex = 13;
            label3.Text = "가격";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(60, 207);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 32);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(6, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 27);
            label2.TabIndex = 11;
            label2.Text = "수량";
            // 
            // sirupNumber
            // 
            sirupNumber.Location = new System.Drawing.Point(60, 120);
            sirupNumber.Name = "sirupNumber";
            sirupNumber.Size = new System.Drawing.Size(120, 32);
            sirupNumber.TabIndex = 10;
            sirupNumber.ValueChanged += sirupNumber_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(6, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 27);
            label1.TabIndex = 9;
            label1.Text = "시럽";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(309, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(102, 29);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "얼음 많이";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new System.Drawing.Point(156, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(100, 29);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "얼음 보통";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(3, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(95, 29);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "얼음적게";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(289, 478);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(201, 77);
            button2.TabIndex = 7;
            button2.Text = "확인";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(12, 478);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(201, 77);
            button1.TabIndex = 8;
            button1.Text = "이전";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(502, 567);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form7";
            Text = "Form7";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sirupNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sirupNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label3;
    }
}