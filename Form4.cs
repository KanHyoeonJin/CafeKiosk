using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class Form4 : Form
    {
        private string menu;
        private string option;
        private int value;
        private string eat;
        private string temper;
        private Form3 form3;
        public Form4()
        {
            InitializeComponent();
            this.menu = "";
            this.option = "";
            this.value = 0;
            this.eat = "";
        }
        public Form4(string eat)
        {
            this.menu = "";
            this.option = "";
            this.value = 0;
            this.eat = eat;
        }
        public Form4(Form3 form3,string option, int value, string eat)
        {
            InitializeComponent();
            this.form3 = form3;
            this.option = option;
            this.value = value;
            this.eat = eat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //아메리카노 선택
            this.menu = "아메리카노";
            Form5 form5 = new Form5(this.form3,this.menu, this.eat);
            form5.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //이전 버튼
            form3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //카페라떼 설정
            this.menu = "카페라떼";
            Form5 form5 = new Form5(this.form3,this.menu, this.eat);
            form5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //아인슈페너 설정
            this.menu = "아인슈페너";
            Form5 form5 = new Form5(this.form3, this.menu, this.eat);
            form5.Show(); this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //카푸치노 설정
            this.menu = "카푸치노";
            Form5 form5 = new Form5(this.form3,menu, this.eat);
            form5.Show(); this.Close();
        }
    }
}
