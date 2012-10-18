using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Guid
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            CreateNewGuid();

        }

        private void CreateNewGuid()
        {
            System.Guid g = System.Guid.NewGuid();

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("N: {0}\r\n", g.ToString("N"));
            sb.AppendFormat("D: {0}\r\n", g.ToString("D"));
            sb.AppendFormat("B: {0}\r\n", g.ToString("B"));
            sb.AppendFormat("P: {0}\r\n", g.ToString("P"));

            this.textBoxGuid.Text = sb.ToString();

            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreateNewGuid();

        }
    }
}