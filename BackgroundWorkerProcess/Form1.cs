using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerProcess
{
    public partial class Form1 : Form
    {
        sequence _seq = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _seq = new sequence();
            flowLayoutPanel1.Controls.Add(_seq._userControl);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process();
        }

        public void process() {
            if (!_seq.IsBusy)
                _seq.RunWorkerAsync();
        }
    }
}
