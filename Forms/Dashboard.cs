using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VMS.Forms
{
    public partial class Dashboard : System.Windows.Forms.Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Vaccination VC1 = new Vaccination();
            VC1.Show();
            this.Hide();

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Centers CE1 = new Centers();
            CE1.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
