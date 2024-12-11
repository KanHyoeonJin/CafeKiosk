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
    public partial class Form2 : Form
    {
        private string eat;
        private Form3 form3;
        public Form2()
        {
            InitializeComponent();
            eat = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.eat = button2.Text;
            form3 = new Form3(eat);
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eat = button1.Text;
            form3 = new Form3(eat);
            form3.Show();
            this.Hide();
        }
    }
}
