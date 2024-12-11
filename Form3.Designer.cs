namespace CafeKiosk
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            btn_coffee = new System.Windows.Forms.Button();
            btn_smooth = new System.Windows.Forms.Button();
            btn_buy = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btn_last = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_coffee
            // 
            btn_coffee.BackgroundImage = Properties.Resources.coffee;
            btn_coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_coffee.FlatAppearance.BorderSize = 0;
            btn_coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_coffee.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_coffee.ForeColor = System.Drawing.SystemColors.Control;
            btn_coffee.Location = new System.Drawing.Point(12, 108);
            btn_coffee.Name = "btn_coffee";
            btn_coffee.Size = new System.Drawing.Size(217, 168);
            btn_coffee.TabIndex = 0;
            btn_coffee.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btn_coffee.UseVisualStyleBackColor = true;
            btn_coffee.Click += button1_Click;
            // 
            // btn_smooth
            // 
            btn_smooth.BackgroundImage = Properties.Resources.smooth;
            btn_smooth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_smooth.FlatAppearance.BorderSize = 0;
            btn_smooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_smooth.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_smooth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_smooth.Location = new System.Drawing.Point(387, 108);
            btn_smooth.Name = "btn_smooth";
            btn_smooth.Size = new System.Drawing.Size(217, 168);
            btn_smooth.TabIndex = 1;
            btn_smooth.UseVisualStyleBackColor = true;
            btn_smooth.Click += btn_smooth_Click;
            // 
            // btn_buy
            // 
            btn_buy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btn_buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_buy.FlatAppearance.BorderSize = 0;
            btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_buy.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_buy.Location = new System.Drawing.Point(315, 713);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new System.Drawing.Size(175, 59);
            btn_buy.TabIndex = 5;
            btn_buy.Text = "결제";
            btn_buy.UseVisualStyleBackColor = false;
            btn_buy.Click += btn_buy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 470);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 31);
            label1.TabIndex = 6;
            label1.Text = "결제 내역";
            // 
            // btn_last
            // 
            btn_last.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btn_last.FlatAppearance.BorderSize = 0;
            btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_last.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_last.Location = new System.Drawing.Point(12, 713);
            btn_last.Name = "btn_last";
            btn_last.Size = new System.Drawing.Size(175, 59);
            btn_last.TabIndex = 7;
            btn_last.Text = "이전";
            btn_last.UseVisualStyleBackColor = false;
            btn_last.Click += button3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 삭제ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem
            // 
            삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            삭제ToolStripMenuItem.Text = "삭제";
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new System.Drawing.Point(12, 504);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(478, 179);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(518, 640);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 43);
            button1.TabIndex = 11;
            button1.Text = "삭제";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(518, 504);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 25);
            label2.TabIndex = 12;
            label2.Text = "총액";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(518, 544);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 27);
            label3.TabIndex = 12;
            label3.Text = "0";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(630, 784);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btn_last);
            Controls.Add(label1);
            Controls.Add(btn_buy);
            Controls.Add(btn_smooth);
            Controls.Add(btn_coffee);
            Name = "Form3";
            Text = "Form3";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_coffee;
        private System.Windows.Forms.Button btn_smooth;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}