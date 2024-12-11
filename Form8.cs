using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class Form8 : Form
    {
        private int value;
        Form3 form3;
        private string str;
        private int cnt=0;
        public Form8()
        {
            InitializeComponent();

        }
        public Form8(Form3 form3, int value)
        {
            InitializeComponent();
            this.value = value;
            this.form3 = form3;
            lb_price.Text = this.value.ToString();
        }




        private void btn_back_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                MessageBox.Show($"총 금액 {value}원 결제에 성공했습니다.");
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"결제 방법을 선택해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = "토스결제";
            lb_solution.Text = str;
            btn_toss.FlatAppearance.BorderSize = 3;
            btn_kakao.FlatAppearance.BorderSize = 0;
            btn_cash.FlatAppearance.BorderSize = 0;
            btn_card.FlatAppearance.BorderSize = 0;
            this.cnt = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = "카카오페이 결제";
            lb_solution.Text = str;
            btn_kakao.FlatAppearance.BorderSize = 3;
            btn_toss.FlatAppearance.BorderSize= 0;
            btn_cash.FlatAppearance.BorderSize = 0;
            btn_card.FlatAppearance.BorderSize = 0;
            this.cnt = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str = "카드결제";
            lb_solution.Text = str;
            btn_card.FlatAppearance.BorderSize = 3;
            btn_cash.FlatAppearance.BorderSize = 0;
            btn_toss.FlatAppearance.BorderSize = 0;
            btn_kakao.FlatAppearance.BorderSize = 0;
            this.cnt = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str = "현금결제";
            lb_solution.Text = str;
            btn_cash.FlatAppearance.BorderSize = 3;
            btn_card.FlatAppearance.BorderSize = 0;
            btn_kakao.FlatAppearance.BorderSize = 0;
            btn_toss.FlatAppearance.BorderSize = 0;
            this.cnt = 1;
        }
    }
}
