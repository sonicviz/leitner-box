using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Leitner
{
    public partial class AboutForm : Leitner.BaseForms.BaseChildForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            for (float i = 0; i < 1; i += 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (float i = 1; i > 0; i -= 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }
    }
}
