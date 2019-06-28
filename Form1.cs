using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RX580_AntiAFK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Visible = true;
            timer1.Start();
            progressBar1.Visible = true;
            antiAfk go = new antiAfk();
            go.StartLoop();
            button1.Visible = false;
            button2.ForeColor = System.Drawing.Color.LimeGreen;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int loopTrig = 0; loopTrig <= 100; loopTrig++)
            {

                progressBar1.Value = loopTrig;
                Application.DoEvents();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SendKeys.Send("%");
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;
            button1.Visible = true;
            button2.ForeColor = System.Drawing.Color.Black;
            progressBar1.Visible = false;  

        }
    }
}
