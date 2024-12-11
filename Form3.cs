using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class Form3 : Form
    {

        private string eat;
        private string option;
        private int value = 0;
        private string temper;
        private int[] arr = new int[10];
        private int cnt = 0;
        private int index;

        int sum = 0;


        public Form3()
        {
            InitializeComponent();
            this.eat = "";

            this.option = string.Empty;
            this.value = 0;

        }
        public Form3(string eat)
        {
            InitializeComponent();
            this.eat = eat;

            this.option = string.Empty;
            this.value = 0;
        }
        public Form3(string option, int value, string eat, string temper)
        {
            InitializeComponent();

            this.option = option;
            this.eat = eat;
            this.value = value;
            this.temper = temper;
        }
        public void AddList(string item)
        {
            listBox1.Items.Add(item);
        }
        public int Arr
        {
            set
            {
                arr[cnt] = value;
                cnt++;
                sum = 0;
                for (int i = 0; i < cnt; i++)
                {
                    sum += arr[i];
                }
                label3.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //커피 선택
            Form4 form4 = new Form4(this, option, value, eat);
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //이전 버튼
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }



        private void btn_smooth_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this, eat);
            form6.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int selectedIndex = listBox1.SelectedIndex;
                    sum -= arr[selectedIndex];
                    arr[selectedIndex] = 0;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    //배열의 나머지 값 재정렬
                    for (int i = selectedIndex; i < cnt - 1; i++)
                    {
                        arr[i] = arr[i + 1]; // 배열 값 재정렬
                    }
                    //마지막 배열 값 초기화
                    arr[cnt - 1] = 0;
                    cnt--;
                    label3.Text = sum.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"결제 창으로 이동합니다.");
            Form8 form8 = new Form8(this,sum);
            form8.Show();
            this.Hide();
        }
    }
}
