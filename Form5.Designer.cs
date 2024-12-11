namespace CafeKiosk
{
    partial class Form5
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
            drinkNumber = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sirupNumber = new System.Windows.Forms.NumericUpDown();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drinkNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sirupNumber).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_price);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(drinkNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(sirupNumber);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(417, 376);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "옵션";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new System.Drawing.Point(60, 276);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(22, 25);
            lb_price.TabIndex = 12;
            lb_price.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 276);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 25);
            label3.TabIndex = 11;
            label3.Text = "가격";
            // 
            // drinkNumber
            // 
            drinkNumber.Location = new System.Drawing.Point(60, 179);
            drinkNumber.Name = "drinkNumber";
            drinkNumber.Size = new System.Drawing.Size(120, 32);
            drinkNumber.TabIndex = 10;
            drinkNumber.ValueChanged += drinkNumber_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(6, 179);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 27);
            label2.TabIndex = 9;
            label2.Text = "수량";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(6, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 27);
            label1.TabIndex = 8;
            label1.Text = "시럽";
            // 
            // sirupNumber
            // 
            sirupNumber.Location = new System.Drawing.Point(60, 81);
            sirupNumber.Name = "sirupNumber";
            sirupNumber.Size = new System.Drawing.Size(120, 32);
            sirupNumber.TabIndex = 7;
            sirupNumber.ValueChanged += sirupNumber_ValueChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton2.Location = new System.Drawing.Point(150, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(51, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ice";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButton1.Location = new System.Drawing.Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(56, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "hot";
            radioButton1.UseVisualStyleBackColor = true;
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
            button1.TabIndex = 2;
            button1.Text = "이전";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(304, 478);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(201, 77);
            button2.TabIndex = 6;
            button2.Text = "확인";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(502, 567);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drinkNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)sirupNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown sirupNumber;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown drinkNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label3;
    }
}