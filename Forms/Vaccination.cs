using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace VMS
{
    public partial class Vaccination : System.Windows.Forms.Form
    {

        Bunifu.DataViz.DataPoint datapoint1;


        public Vaccination()
        {
            InitializeComponent();
            RenderChart();
        }

        private void Vaccination_Load(object sender, EventArgs e)
        {

            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Forms.VCNow VCN1 = new Forms.VCNow();
            VCN1.Show();
            this.Hide();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        public void RenderChart()
        {
           
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Random random = new Random();

            datapoint1.addLabely("1", random.Next(0, 50).ToString());
            datapoint1.addLabely("2", random.Next(0, 50).ToString());
            datapoint1.addLabely("3", random.Next(0, 50).ToString());
            datapoint1.addLabely("4", random.Next(0, 50).ToString());
            datapoint1.addLabely("5", random.Next(0, 50).ToString());
            datapoint1.addLabely("6", random.Next(0, 50).ToString());
            datapoint1.addLabely("7", random.Next(0, 50).ToString());
            datapoint1.addLabely("8", random.Next(0, 50).ToString());
            datapoint1.addLabely("9", random.Next(0, 50).ToString());
            datapoint1.addLabely("10", random.Next(0, 50).ToString());
            datapoint1.addLabely("11", random.Next(0, 50).ToString());
            datapoint1.addLabely("12", random.Next(0, 50).ToString());

            canvas.addData(datapoint1);
            bunifuDataViz1.Render(canvas);

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            

            Forms.Dashboard DB = new Forms.Dashboard();
            DB.Show();
            this.Hide();
        }
    }
}
