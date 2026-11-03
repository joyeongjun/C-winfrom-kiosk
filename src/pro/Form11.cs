using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Size = this.Size;
            form12.StartPosition = FormStartPosition.Manual;
            form12.Location = this.Location;
            form12.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Size = this.Size;
            form13.StartPosition = FormStartPosition.Manual;
            form13.Location = this.Location;
            form13.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Size = this.Size;
            form14.StartPosition = FormStartPosition.Manual;
            form14.Location = this.Location;
            form14.ShowDialog();
        }
    }
}
