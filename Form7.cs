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
    public partial class Form7 : Form
    {
        private string eat;
        private string option;
        private int value;
        private string temper;
        private string menu;
        private int price;
        private Form3 form3;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(Form3 form3, string eat, string menu)
        {

            this.eat = eat;
            InitializeComponent();
            this.form3 = form3;
            this.option = string.Empty;
            this.value = 0;
            this.temper = string.Empty;
            this.menu = menu;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                if (this.eat == "매장" && this.menu == "딸기스무디")
                {
                    this.value = 4000;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "포장" && this.menu == "딸기스무디")
                {
                    this.value = 3000;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "매장" && this.menu == "딸기요거트스무디")
                {
                    this.value = 4500;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "포장" && this.menu == "딸기요거트스무디")
                {
                    this.value = 3500;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "매장" && this.menu == "밀크셰이크")
                {
                    this.value = 5000;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "포장" && this.menu == "밀크셰이크")
                {
                    this.value = 4000;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "매장" && this.menu == "자바칩프라페")
                {
                    this.value = 4500;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
                else if (this.eat == "포장" && this.menu == "자바칩프라페")
                {
                    this.value = 3500;
                    lb_price.Text = (this.value * numericUpDown1.Value) + "원";
                    price = this.value * (int)numericUpDown1.Value;
                }
            }
            
           

        }

        private void sirupNumber_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if(sirupNumber.Value>0)
                {
                    this.option = radioButton1.Text + " " + label1.Text + sirupNumber.Value + "번 ";
                }
                else
                {
                    this.option = radioButton1.Text + " ";
                }
                
            }
            else if (radioButton2.Checked)
            {
                if(sirupNumber.Value > 0)
                {
                    this.option = radioButton2.Text + " " + label1.Text + sirupNumber.Value + "번 ";
                }
                else
                {
                    this.option = radioButton2.Text + " ";
                }
               
            }
            else if (radioButton3.Checked)
            {
                if(sirupNumber.Value>0)
                {
                    this.option = radioButton3.Text + " " + label1.Text + sirupNumber.Value + "번 ";
                }
                else
                {
                    this.option = radioButton3.Text + " ";
                }
                
            }
            else
            {
                MessageBox.Show("얼음 양을 선택해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.numericUpDown1.Value>0)
            {
                form3.AddList(this.eat + " " + this.menu + " " + this.option + this.numericUpDown1.Value + "잔 " + this.price + "원");
                form3.Arr = this.price;
                form3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("수량을 골라주세요");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this.form3, eat);
            form6.Show();
            this.Close();
        }

    }
}
