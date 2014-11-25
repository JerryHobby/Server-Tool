using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server_Tool_Network;


namespace Server_Tool_Form
{
    public partial class Form1 : Form
    {
        Network MyNetwork = new Network();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = MyNetwork.StatusMessage();
        }
    }
}
