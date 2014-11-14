using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Leitner
{
    public partial class ReviewForm : Leitner.BaseForms.BaseChildForm
    {
        LeitnerDataContext db = new LeitnerDataContext();

        private static string online_Username;

        public string Online_Username
        {
            set
            {
                online_Username = value;
            }
        }

        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ReviewForm_Shown(object sender, EventArgs e)
        {
            for (float i = 0; i < 1; i += 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (float i = 1; i > 0; i -= 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            var query = from w in db.Tbl_Words
                        where w.User_Name.Trim() == online_Username &&
                        w.Word_Situation.Trim() == "M_0"
                        select w;

            DataGridView.DataSource = query;
        }

        private void Btn_Meaning_Click(object sender, EventArgs e)
        {
            if (Btn_Meaning.Checked == true)
                this.persianWordDataGridViewTextBoxColumn.Visible = true;
            else
                this.persianWordDataGridViewTextBoxColumn.Visible = false;           
        }
    }
}
