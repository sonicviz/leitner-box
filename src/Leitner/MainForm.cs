using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SpeechLib;
using System.Threading;

namespace Leitner
{
    public partial class MainForm : KryptonForm
    {
        Thread speech;
        string speech_str;

        LeitnerDataContext db = new LeitnerDataContext();

        Leitner.BaseForms.BaseMessageBox mesg = new Leitner.BaseForms.BaseMessageBox();

        Boolean nonNumberEntered;

        private static string online_Username;

        private static Boolean goto_Login;

        public string Online_Username
        {
            set
            {
                online_Username = value;
            }
        }

        public Boolean Goto_Login
        {
            get
            {
                return goto_Login;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public string TodayDate()
        {
            return DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
        }

        public void Speak()
        {
            try
            {
                SpVoice spVoice = new SpVoice();
                SpeechVoiceSpeakFlags svsp = new SpeechVoiceSpeakFlags();
                spVoice.Speak(speech_str, svsp);
            }
            catch { }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            for (float i = 0; i < 1; i += 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (float i = 1; i >0; i -= 0.02f)
            {
                this.Opacity = i;
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }

        ///////////// Menu

        private void BtnTest_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.ValuesPrimary.Heading = "آزمون لغات";
            BtnSetting.Checked = false;
            BtnBank.Checked = false;
            BtnTest.Checked = true;

            Btn_Answer.Visible = true;
            lbl_meaning.Visible = false;
            txt_meaning.Visible = false;

            tabPage_bank.Hide();
            tabPage_setting.Hide();
            tabPage_test.Show();

            Load_Tests();
        }

        private void BtnBank_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.ValuesPrimary.Heading = "بانک لغات";
            BtnSetting.Checked = false;
            BtnTest.Checked = false;
            BtnBank.Checked = true;

            txt_NumWords.Clear();
            Cmb_Word.Text = "";

            tabPage_bank.Show();
            tabPage_setting.Hide();
            tabPage_test.Hide();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.ValuesPrimary.Heading = "تنظیمات کاربری";
            BtnBank.Checked = false;
            BtnTest.Checked = false;
            BtnSetting.Checked = true;

            txt_NewPassword.Clear();
            txt_OldPassword.Clear();
            txt_RepeatNewPassword.Clear();

            tabPage_bank.Hide();
            tabPage_setting.Show();
            tabPage_test.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            goto_Login = true;
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ///////////// Test

        public string Get_DayString(string situation)
        {
            switch (Convert.ToInt32(situation.Substring(2)))
            {
                case 0:
                    txt_Situation.BackColor = System.Drawing.SystemColors.ControlLight;
                    return "خوانده نشده";
                case 1:
                    txt_Situation.BackColor = Color.SkyBlue;
                    return "روز اول";
                case 3:
                    txt_Situation.BackColor = Color.PaleGreen;
                    return "روز سوم";
                case 7:
                    txt_Situation.BackColor = Color.Chocolate;
                    return "روز هفتم";
                case 14:
                    txt_Situation.BackColor = Color.LightCoral;
                    return "روز چهاردهم";
                case 30:
                    txt_Situation.BackColor = Color.Gold;
                    return "روز سی ام";
                default:
                    txt_Situation.BackColor = System.Drawing.SystemColors.ControlLight;
                    return "خطا";
            }
        }

        public void Load_Tests()
        {
            try
            {
                var query = from w in db.Tbl_Words
                            where w.User_Name.Trim() == online_Username &&
                            w.Word_Situation.Trim() != "M_Archive" &&
                            (w.Word_Situation.Trim() == "M_0" ||
                            w.Word_Situation.Trim() == "M_1" ||
                            w.Word_Situation.Trim() == "M_3" ||
                            w.Word_Situation.Trim() == "M_7" ||
                            w.Word_Situation.Trim() == "M_14" ||
                            w.Word_Situation.Trim() == "M_30")
                            orderby Convert.ToInt32(w.Word_Situation.Trim().Substring(2)) descending
                            select w;
                
                if (query.Count() != 0)
                {
                    txt_Word.Text = query.First().English_Word.Trim();
                    txt_meaning.Text = query.First().Persian_Word.Trim();
                    txt_Situation.Text = Get_DayString(query.First().Word_Situation.Trim());

                    Btn_Answer.Enabled = true;
                    Btn_True.Enabled = true;
                    Btn_False.Enabled = true;
                }
                else
                {
                    txt_Word.Clear();
                    txt_Situation.BackColor = System.Drawing.SystemColors.ControlLight;
                    txt_Situation.Clear();
                    Btn_Answer.Enabled = false;
                    Btn_True.Enabled = false;
                    Btn_False.Enabled = false;
                }                
            }
            catch (Exception ex)
            {
                mesg.Warning("توجه", ex.Message);
            }
        }

        public void Word_Numers()
        {
            var query3 = from w in db.Tbl_Words
                         where w.User_Name.Trim() == online_Username &&
                         w.Word_Situation.Trim() != "M_0"
                         select w;
            txt_total.Text = query3.Count().ToString();

            var query4 = from w in db.Tbl_Words
                         where w.User_Name.Trim() == online_Username &&
                         w.Word_Situation.Trim() == "M_Archive"
                         select w;
            txt_Archive.Text = query4.Count().ToString();

            var query5 = from w in db.Tbl_Words
                         where w.User_Name.Trim() == online_Username &&
                         w.Word_Situation.Trim() == "M_0"
                         select w;
            txt_Unread.Text = query5.Count().ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            goto_Login = false;

            try
            {
                var query = (from u in db.Tbl_Users
                            where u.User_Name.Trim() == online_Username
                            select u).Single();

                if (query.Last_Visit.Trim() != TodayDate())
                {
                    query.Last_Visit = TodayDate();
                    db.SubmitChanges();

                    var query2 = from w in db.Tbl_Words
                                 where w.User_Name.Trim() == online_Username &&
                                 w.Word_Situation.Trim() != "M_Archive"
                                 select w;

                    foreach (var row in query2)
                    {
                        if (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) == 2)
                            row.Word_Situation = "M_3";
                        else if (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) >= 4 && Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) <= 6)
                            row.Word_Situation = "M_" + (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) + 1).ToString();
                        else if (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) >= 8 && Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) <= 13)
                            row.Word_Situation = "M_" + (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) + 1).ToString();
                        else if (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) >= 15 && Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) <= 29)
                            row.Word_Situation = "M_" + (Convert.ToInt32(row.Word_Situation.Trim().Substring(2)) + 1).ToString();
                    }

                    db.SubmitChanges();
                }

                Load_Tests();
                
                Word_Numers();
                
            }
            catch (Exception ex)
            {
                mesg.Warning("توجه",ex.Message);
            }
        }

        private void Btn_TextToSpeech_Click(object sender, EventArgs e)
        {
            speech_str = txt_Word.Text;
            speech = new Thread(new ThreadStart(this.Speak));
            speech.Start();
        }

        private void Btn_Answer_Click(object sender, EventArgs e)
        {
            Btn_Answer.Visible = false;
            lbl_meaning.Visible = true;
            txt_meaning.Visible = true;
        }

        private void Btn_False_Click(object sender, EventArgs e)
        {
            try
            {
                Btn_Answer.Visible = true;
                lbl_meaning.Visible = false;
                txt_meaning.Visible = false;

                var query = (from w in db.Tbl_Words
                            where w.User_Name.Trim() == online_Username &&
                            w.English_Word.Trim() == txt_Word.Text.Trim()
                            select w).Single();

                if (query.Word_Situation.Trim() == "M_0")
                {
                    query.Word_Situation = "M_0";
                }
                else
                    query.Word_Situation = "M_1";
                db.SubmitChanges();

                Load_Tests();
            }
            catch (Exception ex)
            {
                mesg.Warning("توجه", ex.Message);
            }
        }

        private void Btn_True_Click(object sender, EventArgs e)
        {
            try
            {
                Btn_Answer.Visible = true;
                lbl_meaning.Visible = false;
                txt_meaning.Visible = false;

                var query = (from w in db.Tbl_Words
                             where w.User_Name.Trim() == online_Username &&
                             w.English_Word.Trim() == txt_Word.Text.Trim()
                             select w).Single();

                if (query.Word_Situation.Trim() == "M_30")
                {
                    query.Word_Situation = "M_Archive";
                    txt_Archive.Text = (Convert.ToInt32(txt_Archive.Text) + 1).ToString();
                }
                else if (query.Word_Situation.Trim() == "M_0")
                {
                    query.Word_Situation = "M_2";
                    txt_Unread.Text = (Convert.ToInt32(txt_Unread.Text) - 1).ToString();
                    txt_total.Text = (Convert.ToInt32(txt_total.Text) + 1).ToString();
                }
                else
                    query.Word_Situation = "M_" + (Convert.ToInt32(query.Word_Situation.Trim().Substring(2)) + 1).ToString();

                db.SubmitChanges();

                Load_Tests();
            }
            catch (Exception ex)
            {
                mesg.Warning("توجه", ex.Message);
            }
        }

        ///////////// Bank

        private void Btn_Speech_Click(object sender, EventArgs e)
        {
            speech_str = Cmb_Word.Text;
            speech = new Thread(new ThreadStart(this.Speak));
            speech.Start();
        }

        private void Cmb_Word_TextChanged(object sender, EventArgs e)
        {
                 try
                 {
                     var query = from w in db.Tbl_Words
                                 where Cmb_Word.Text.Trim() == w.English_Word.Trim().Substring(0, Cmb_Word.Text.Trim().Length)
                                 && w.User_Name.Trim() == online_Username
                                 select w;

                     foreach (var row in query)
                     {
                         Cmb_Word.AutoCompleteCustomSource.Add(row.English_Word.Trim());
                     }

                     var query2 = from w in db.Tbl_Words
                                 where w.English_Word.Trim() == Cmb_Word.Text.Trim() && w.User_Name.Trim() == online_Username
                                 select w;
                     if (query2.Count() == 1)
                     {
                         txt_Defination.Text = query2.First().Persian_Word.Trim();
                     }
                     else
                         txt_Defination.Clear();
                     
                 }
                 catch (Exception ex)
                 {
                     mesg.Error("خطا", ex.Message);
                 }
        }

        private void Cmb_Word_Leave(object sender, EventArgs e)
        {
            Cmb_Word.AutoCompleteCustomSource.Clear();
        }

        private void txt_Defination_Enter(object sender, EventArgs e)
        {
            try
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            }
            catch { }
        }

        private void txt_Defination_Leave(object sender, EventArgs e)
        {
            try
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            }
            catch { }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Word.Text.Trim() == "") throw new Exception("لطفا لغت مورد نظر را وارد کنید!");
                if (txt_Defination.Text.Trim() == "") throw new Exception("لطفا معنی لغت مورد نظر را وارد کنید!");

                var query = from w in db.Tbl_Words
                            where w.English_Word.Trim() == Cmb_Word.Text.Trim() && w.User_Name.Trim() == online_Username
                            select w;

                if (query.Count() == 0)     //Insert
                {
                    Tbl_Word word = new Tbl_Word();
                    word.English_Word = Cmb_Word.Text.Trim();
                    word.Persian_Word = txt_Defination.Text.Trim();
                    word.User_Name = online_Username;
                    word.Word_Situation = "M_0";
                    word.Insert_Date = DateTime.Now;
                    db.Tbl_Words.InsertOnSubmit(word);
                    db.SubmitChanges();
                    txt_Unread.Text = (Convert.ToInt32(txt_Unread.Text) + 1).ToString();
                }
                else                        //Update
                {
                    query.First().Persian_Word = txt_Defination.Text.Trim();
                    query.First().Word_Situation = "M_1";
                    query.First().Insert_Date = DateTime.Now;
                    db.SubmitChanges();
                }

                Cmb_Word.Text = "";
                txt_Defination.Clear();
                Word_Numers();
                Cmb_Word.Focus();

            }
            catch (Exception ex)
            {
                mesg.Warning("توجه", ex.Message);
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                var Query = from w in db.Tbl_Words
                             where w.English_Word.Trim() == Cmb_Word.Text.Trim() && w.User_Name.Trim() == online_Username
                             select w;

                if (Query.Count() == 0) throw new Exception("لغت مورد نظر یافت نشد!");
                db.Tbl_Words.DeleteOnSubmit(Query.First());
                db.SubmitChanges();

                Cmb_Word.Text = "";
                txt_Defination.Clear();
                Cmb_Word.Focus();
            }
            catch (Exception ex)
            {
                mesg.Warning("توجه", ex.Message);
            }
        }

        private void txt_NumWords_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                        nonNumberEntered = true;
        }

        private void txt_NumWords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true;
        }

        private void Btn_Review_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NumWords.Text == "" || Convert.ToInt32(txt_NumWords.Text) < 1 ) throw new Exception("لطفا تعداد لغات را وارد کنید!");

                var query = from w in db.Tbl_Words
                            where (w.User_Name.Trim() == online_Username &&
                            w.Word_Situation.Trim() == "M_Archive")
                            orderby w.Insert_Date
                            select w;

                int i = 0;
                
                foreach (var row in query)
                {
                    row.Word_Situation = "M_1";
                    i++;
                    if (i == Convert.ToInt32(txt_NumWords.Text)) break;
                }

                db.SubmitChanges();

                txt_NumWords.Clear();
                mesg.Information("توجه", i.ToString() + " " + "لغت با موفقیت بازیابی شد.");

                Word_Numers();

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void Btn_FirstDayWords_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.ShowDialog();
        }

        ///////////// Setting

        private void Btn_PasswordChangeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_OldPassword.Text.Trim() == "") throw new Exception("لطفا کلمه عبور قدیمی خود را وارد کنید!");
                if (txt_NewPassword.Text.Trim() == "") throw new Exception("لطفا کلمه عبور جدید خود را وارد کنید!");
                if (txt_RepeatNewPassword.Text.Trim() == "") throw new Exception("لطفا تکرار کلمه عبور جدید خود را وارد کنید!");
                if (txt_NewPassword.Text.Trim() != txt_RepeatNewPassword.Text.Trim()) throw new Exception("کلمات عبور جدید وارد شده تطابق ندارند!");

                //Check Old Password
                var query = (from u in db.Tbl_Users
                            where u.User_Name.Trim() == online_Username
                            select u).Single();

                if (query.User_Password.Trim() != txt_OldPassword.Text.Trim().Replace("ی", "ي")) throw new Exception("لطفا کلمه عبور قدیمی خود را درست وارد کنید!");

                //Change Password
                query.User_Password = txt_NewPassword.Text.Trim().Replace("ی", "ي");

                db.SubmitChanges();

                txt_OldPassword.Clear();
                txt_NewPassword.Clear();
                txt_RepeatNewPassword.Clear();

                mesg.Information("توجه","کلمه عبور شما با موفیت تعویض شد.");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void Btn_RemoveAll_Click(object sender, EventArgs e)
        {
                try
                {
                    if (mesg.Question("خطر", "آیا مطمئن هستید که قصد پاک کردن حساب خود را دارید؟"))
                    {
                        var query = (from u in db.Tbl_Users
                                     where u.User_Name.Trim() == online_Username
                                     select u).Single();
                        db.Tbl_Users.DeleteOnSubmit(query);
                        db.SubmitChanges();

                        mesg.Information("توجه","حساب کاربری و کلمات شما با موفقیت پاک شد.");

                        goto_Login = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    mesg.Error("خطا", ex.Message);
                }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void دربارهنرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

                   
                        


    }
}
