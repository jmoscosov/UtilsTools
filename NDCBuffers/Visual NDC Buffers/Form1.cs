using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Visual_NDC_Buffers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
            }
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            GetSystemInfo();
        }

        private void GetSystemInfo()
        {
            Computer pc = new Computer();
            //label11.Text = System.Environment.OSVersion.Platform.ToString() + "/" + System.Environment.OSVersion.Version.ToString() + "/" + System.Environment.OSVersion.ToString();
            label11.Text = pc.Info.OSFullName.ToString() + "/" + System.Environment.OSVersion.Version.ToString();
        }
        private void UpdateCounters()
        {

        }
    }
}
