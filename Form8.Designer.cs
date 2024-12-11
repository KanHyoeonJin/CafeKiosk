namespace CafeKiosk
{
    partial class Form8
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
            label1 = new System.Windows.Forms.Label();
            lb_price = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btn_back = new System.Windows.Forms.Button();
            btn_toss = new System.Windows.Forms.Button();
            btn_kakao = new System.Windows.Forms.Button();
            btn_card = new System.Windows.Forms.Button();
            btn_cash = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lb_solution = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "결제 금액";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_price.Location = new System.Drawing.Point(127, 33);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(22, 25);
            lb_price.TabIndex = 1;
            lb_price.Text = "-";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(348, 337);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(167, 77);
            button1.TabIndex = 4;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_back.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_back.Location = new System.Drawing.Point(12, 337);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(167, 77);
            btn_back.TabIndex = 4;
            btn_back.Text = "이전";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_toss
            // 
            btn_toss.BackgroundImage = Properties.Resources.다운로드__1_;
            btn_toss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_toss.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btn_toss.FlatAppearance.BorderSize = 0;
            btn_toss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_toss.Location = new System.Drawing.Point(19, 83);
            btn_toss.Name = "btn_toss";
            btn_toss.Size = new System.Drawing.Size(160, 79);
            btn_toss.TabIndex = 5;
            btn_toss.UseVisualStyleBackColor = true;
            btn_toss.Click += button2_Click;
            // 
            // btn_kakao
            // 
            btn_kakao.BackgroundImage = Properties.Resources.다운로드;
            btn_kakao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_kakao.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btn_kakao.FlatAppearance.BorderSize = 0;
            btn_kakao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_kakao.Location = new System.Drawing.Point(348, 83);
            btn_kakao.Name = "btn_kakao";
            btn_kakao.Size = new System.Drawing.Size(160, 79);
            btn_kakao.TabIndex = 6;
            btn_kakao.UseVisualStyleBackColor = true;
            btn_kakao.Click += button3_Click;
            // 
            // btn_card
            // 
            btn_card.BackgroundImage = Properties.Resources.kard;
            btn_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_card.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btn_card.FlatAppearance.BorderSize = 0;
            btn_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_card.Location = new System.Drawing.Point(19, 187);
            btn_card.Name = "btn_card";
            btn_card.Size = new System.Drawing.Size(160, 79);
            btn_card.TabIndex = 7;
            btn_card.UseVisualStyleBackColor = true;
            btn_card.Click += button4_Click;
            // 
            // btn_cash
            // 
            btn_cash.BackgroundImage = Properties.Resources.cash;
            btn_cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_cash.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btn_cash.FlatAppearance.BorderSize = 0;
            btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cash.Location = new System.Drawing.Point(348, 187);
            btn_cash.Name = "btn_cash";
            btn_cash.Size = new System.Drawing.Size(160, 79);
            btn_cash.TabIndex = 8;
            btn_cash.UseVisualStyleBackColor = true;
            btn_cash.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 15.7499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 289);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 27);
            label2.TabIndex = 9;
            label2.Text = "결제방법";
            // 
            // lb_solution
            // 
            lb_solution.AutoSize = true;
            lb_solution.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 15.7499981F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lb_solution.Location = new System.Drawing.Point(110, 291);
            lb_solution.Name = "lb_solution";
            lb_solution.Size = new System.Drawing.Size(22, 27);
            lb_solution.TabIndex = 10;
            lb_solution.Text = "-";
            // 
            // Form8
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(527, 450);
            Controls.Add(lb_solution);
            Controls.Add(label2);
            Controls.Add(btn_cash);
            Controls.Add(btn_card);
            Controls.Add(btn_kakao);
            Controls.Add(btn_toss);
            Controls.Add(btn_back);
            Controls.Add(button1);
            Controls.Add(lb_price);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_toss;
        private System.Windows.Forms.Button btn_kakao;
        private System.Windows.Forms.Button btn_card;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_solution;
    }
}