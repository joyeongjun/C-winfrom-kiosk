using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form12 : Form
    {
        string strOrder = "";
        public long totalPrice = 0;
        public Form12()
        {
            InitializeComponent();
            textBox1.Text = "";
        }

        private void labjji_Click(object sender, EventArgs e)
        {

        }

        private void lablu_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";

            if (checkBox1.Checked == true)
                strOrder += checkBox1.Text + "\n";
            if (checkBox2.Checked == true)
                strOrder += checkBox2.Text + "\n";
            if (checkBox3.Checked == true)
                strOrder += checkBox3.Text + "\n";
            if (checkBox4.Checked == true)
                strOrder += checkBox4.Text + "\n";
            if (checkBox5.Checked == true)
                strOrder += checkBox5.Text + "\n";
            if (checkBox6.Checked == true)
                strOrder += checkBox6.Text + "\n";
            lblOrder.Text = strOrder;
            textBox1.Text = totalPrice.ToString();
            if (comboBox1.Text == " " || listBox1.Text == " ")
            {
                MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요.");
                return;
            }
            string str = $"{comboBox1.Text}로 {listBox1.Text}\n결제방법을 선택하셨습니다.\n\n" +
                 $"{totalPrice:N0}원 결제되었습니다.";

            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int one = int.Parse(labone.Text);
            if (checkBox1.Checked)
            {
                totalPrice += one;
            }
            else
                totalPrice -= one;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int jji = int.Parse(labjji.Text);
            if (checkBox2.Checked)
            {
                totalPrice += jji;
            }
            else
                totalPrice -= jji;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int lu = int.Parse(lablu.Text);
            if (checkBox3.Checked)
            {
                totalPrice += lu;
            }
            else
                totalPrice -= lu;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int one1 = int.Parse(labone1.Text);
            if (checkBox4.Checked)
            {
                totalPrice += one1;
            }
            else
                totalPrice -= one1;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int jji1 = int.Parse(labjji1.Text);
            if (checkBox5.Checked)
            {
                totalPrice += jji1;
            }
            else
                totalPrice -= jji1;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int lu1 = int.Parse(lablu1.Text);
            if (checkBox6.Checked)
            {
                totalPrice += lu1;
            }
            else
                totalPrice -= lu1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("일시불");
                listBox1.Items.Add("3개월");
                listBox1.Items.Add("6개월");
            }
        }
    }
}
