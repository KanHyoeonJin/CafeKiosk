using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    
    public partial class Form6 : Form
    {
        
        private string eat;
        private int value;
        private string menu;
        private Form3 form3;
        public Form6()
        {
            InitializeComponent();
            this.eat = string.Empty;
            this.value = 0;
        }
        public Form6(Form3 form3,string eat)
        {
            InitializeComponent();
            this.form3 = form3;
            this.eat = eat;
            this.value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //딸기스무디
            this.menu = button1.Text;
            Form7 form7 = new Form7(this.form3,eat, menu);
            form7.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //딸기요거트스무디
            this.menu = button2.Text;
            Form7 form7 = new Form7(this.form3, eat, menu);
            form7.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //밀크셰이크
            this.menu = button3.Text;
            Form7 form7 = new Form7(this.form3, eat, menu);
            form7.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //자바칩프라페
            this.menu = button4.Text;
            Form7 form7 = new Form7(this.form3, eat, menu);
            form7.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Close();
        }
    }
}
