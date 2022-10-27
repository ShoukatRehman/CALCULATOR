using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console11
{
    public partial class Form1 : Form
    {
        Simple myCal = new Simple();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txt_answer.Text = myCal.Add(Convert.ToInt32(txt_first.Text), Convert.ToInt32(txt_second.Text)).ToString();
            txt_first.Clear();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            txt_answer.Text = myCal.Sub(Convert.ToInt32(txt_first.Text), Convert.ToInt32(txt_second.Text)).ToString();

        }
        private void Clear()
        {
            txt_first.Clear();
            txt_second.Clear();
            txt_answer.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

       
    }
}
