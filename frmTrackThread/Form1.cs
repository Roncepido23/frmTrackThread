using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            Thread ThreadD = new Thread(MyThreadClass.Thread1);


            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();



            
        }
    }
}
