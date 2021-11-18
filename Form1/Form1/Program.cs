using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CSharp_Forms_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            //btnTimeConsumingWork.Enabled = false;
            //btnPrintNumbers.Enabled = false;

            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();

            //btnTimeConsumingWork.Enabled = true;
            //btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listboxNumbers.Items.Add(i);
            }
        }
    }
}
