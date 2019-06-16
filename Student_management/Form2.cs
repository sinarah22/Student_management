using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Student_management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();
        }


        private void backgroundWorker1_RunWorker(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            
            timer1.Start();
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Enabled=false;
        }
    }
}
