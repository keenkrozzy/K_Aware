using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_Aware
{
    public partial class Form1 : Form
    {
		XMLHead head = new XMLHead();

		public Form1()
        {
            InitializeComponent();
			
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //lstbxTest.Items.AddRange(ComputerFetcher.GetComputers().ToArray());
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnWriteXML_Click(object sender, EventArgs e)
		{
			head.Write("Computers","RootComputers", ComputerFetcher.GetComputers().ToArray());
		}

		private void btnReadXML_Click(object sender, EventArgs e)
		{
			head.Read("Computers");
			foreach (KAComputer kac in head.aComputers)
			{
				lstbxTest.Items.Add(kac.name);
			}
		}
	}
}
