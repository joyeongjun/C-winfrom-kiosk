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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void btnone_Click(object sender, EventArgs e)
        {
            //Form10 form10 = new Form10();         
            //form10.Show();
            Form10 form10 = new Form10();
            form10.Size = this.Size;
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location;
            form10.ShowDialog();
        }

        private void btnlu_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Size = this.Size;
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location;
            form10.ShowDialog();
        }

        private void btnjji_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Size = this.Size;
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location;
            form10.ShowDialog();
        }
        }
    }

