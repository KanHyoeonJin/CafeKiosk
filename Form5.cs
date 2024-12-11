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
    public partial class Form5 : Form
    {
        private string menu;
        private string option;
        private int value;
        private string eat;
        private string temper;
        private Form3 form3;
        int count = 0;
        int price = 0;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form3 form3,string menu, string eat)
        {
            InitializeComponent();
            this.form3 = form3;
            this.menu = menu;
            this.eat = eat;
        }

        private void drinkNumber_ValueChanged(object sender, EventArgs e)
        {
            if (this.menu == "아메리카노")
            {
                if (this.eat == "매장")
                {
                    this.value = 2500;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
                else if (this.eat == "포장")
                {
                    this.value = 1500;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
            }
            else if (this.menu == "카페라떼")
            {
                if (this.eat == "매장")
                {
                    this.value = 3900;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
                else if (this.eat == "포장")
                {
                    this.value = 2900;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;

                }
            }
            else if (this.menu == "아인슈페너")
            {
                if (this.eat == "매장")
                {
                    this.value = 4500;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
                else if (this.eat == "포장")
                {
                    this.value = 3500;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
            }
            else if (this.menu == "카푸치노")
            {
                if (this.eat == "매장")
                {
                    this.value = 4000;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
                else if (this.eat == "포장")
                {
                    this.value = 3000;
                    lb_price.Text = (this.value * drinkNumber.Value).ToString();
                    price = this.value * (int)drinkNumber.Value;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (drinkNumber.Value > 0)
                {
                    temper = "Hot";
                    form3.AddList(this.eat + " " + this.temper + " " + this.menu + "  " + this.option + " " + drinkNumber.Value + "잔 " + this.price + "원");
                    form3.Arr = this.price;
                    form3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수량을 확인해주세요");
                }

                
            }

            else if (radioButton2.Checked)
            {
                if (drinkNumber.Value > 0)
                {
                    temper = "Ice";
                    form3.AddList(this.eat + " " + this.temper + " " + this.menu + "  " + this.option + " " + drinkNumber.Value + "잔 " + this.price + "원");
                    form3.Arr = this.price;
                    form3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수량을 확인해주세요");
                }
               
            }
            else
            {
                MessageBox.Show("HOT / ICE 선택해주세요");
            }
           



        }

        private void sirupNumber_ValueChanged(object sender, EventArgs e)
        {
            if (sirupNumber.Value > 0)
            {
                this.option = label1.Text + " " + sirupNumber.Value + "번";
            }
            else
            {
                this.option = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            form3.Show();
            this.Close();
        }
    }
}
