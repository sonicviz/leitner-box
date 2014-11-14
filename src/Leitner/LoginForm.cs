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
    public partial class LoginForm : Leitner.BaseForms.BaseChildForm
    {
        LeitnerDataContext db = new LeitnerDataContext();

        Leitner.BaseForms.BaseMessageBox mesg = new Leitner.BaseForms.BaseMessageBox();

        AutoResetEvent delay = new AutoResetEvent(false);

        private static Boolean ValidUser;

        public Boolean Valid_User
        {
            get
            {
                return ValidUser;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        public string TodayDate()
        {
            return DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
        }

        public void Load_CmbUsername()
        {
            var query = from u in db.Tbl_Users
                        select u;

            Cmb_Username.Items.Clear();
            foreach (var row in query)
            {
                Cmb_Username.Items.Add(row.User_Name.Trim());
            }            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ValidUser = false;
            Load_CmbUsername();
            if (Cmb_Username.Items.Count != 0) Cmb_Username.SelectedIndex = 0;
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) Btn_Login.PerformClick();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Username.Text.Trim() == "") throw new Exception("لطفا نام کاربری را وارد کنید!");
                if (txt_Password.Text.Trim() == "") throw new Exception("لطفا کلمه عبور را وارد کنید!"); 

                var query = from u in db.Tbl_Users
                            where u.User_Name.Trim() == Cmb_Username.Text.Trim().Replace("ی", "ي")
                            && u.User_Password.Trim() == txt_Password.Text.Trim().Replace("ی", "ي")
                            select u;

                if (query.Count() == 1)
                {
                    ValidUser = true;

                    MainForm mfrm = new MainForm();
                    mfrm.Online_Username = Cmb_Username.Text.Trim().Replace("ی", "ي");
                    ReviewForm reviewForm = new ReviewForm();
                    reviewForm.Online_Username = Cmb_Username.Text.Trim().Replace("ی", "ي");

                    this.Close();
                }
                else throw new Exception("لطفا نام کاربری و کلمه عبور را درست وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
                txt_Password.Clear();
                txt_Password.Focus();
            }
        }

        private void Btn_NewClerk_Click(object sender, EventArgs e)
        {
            if(this.Size.Height == 247)
            {
                for (int i = 1; i <= 30; i++)
                {
                    this.Size = new Size(this.Size.Width, this.Height + 5);
                    Application.DoEvents();
                    delay.WaitOne(1, false);
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 397)
            {
                txt_newUsername.Clear();
                txt_newPasword.Clear();
                txt_repeat_newPassword.Clear();
                txt_Password.Clear();

                for (int i = 1; i <= 30; i++)
                {
                    this.Size = new Size(this.Size.Width, this.Height - 5);
                    Application.DoEvents();
                    delay.WaitOne(1, false);
                }

                txt_Password.Focus();
            }
        }

        private void Btn_Sabt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_newUsername.Text.Trim() == "") throw new Exception("لطفا نام کاربری جدید را وارد کنید!");
                else if (txt_newPasword.Text.Trim() == "") throw new Exception("لطفا کلمه عبور جدید را وارد کنید!");
                else if (txt_repeat_newPassword.Text.Trim() == "") throw new Exception("لطفا تکرار کلمه عبور جدید را وارد کنید!");
                else if (txt_newPasword.Text.Trim() != txt_repeat_newPassword.Text.Trim()) throw new Exception("کلمات عبور وارد شده با هم تطابق ندارند!");

                //Check Don't Exist Usename
                var query = from u in db.Tbl_Users
                            where u.User_Name.Trim() == txt_newUsername.Text.Trim().Replace("ی", "ي")
                            select u;
                if (query.Count() != 0) throw new Exception("این نام کاربری موجود می باشد!");
                

                //Insert
                Tbl_User user = new Tbl_User();
                user.User_Name = txt_newUsername.Text.Trim().Replace("ی", "ي");
                user.User_Password = txt_newPasword.Text.Trim().Replace("ی", "ي");
                user.Last_Visit = TodayDate();
                db.Tbl_Users.InsertOnSubmit(user);
                db.SubmitChanges();

                //Return to Login
                Load_CmbUsername();
                Cmb_Username.Text = txt_newUsername.Text.Trim();
                txt_newUsername.Clear();
                txt_newPasword.Clear();
                txt_repeat_newPassword.Clear();
                txt_Password.Clear();

                for (int i = 1; i <= 30; i++)
                {
                    this.Size = new Size(this.Size.Width, this.Height - 5);
                    Application.DoEvents();
                    delay.WaitOne(1, false);
                }

                txt_Password.Focus();

            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            for (float i = 0; i < 1; i += 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
