namespace Leitner
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Cmb_Username = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_NewClerk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Sabt = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_repeat_newPassword = new System.Windows.Forms.TextBox();
            this.txt_newPasword = new System.Windows.Forms.TextBox();
            this.txt_newUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmb_Username
            // 
            this.Cmb_Username.FormattingEnabled = true;
            this.Cmb_Username.Location = new System.Drawing.Point(34, 117);
            this.Cmb_Username.Name = "Cmb_Username";
            this.Cmb_Username.Size = new System.Drawing.Size(140, 24);
            this.Cmb_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(34, 147);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(140, 23);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(203, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(205, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "کلمه عبور";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Leitner.Properties.Resources.Login_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(98, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(151, 183);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(80, 25);
            this.Btn_Login.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Login.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Login.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Login.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Login.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "ورود";
            this.Btn_Login.Values.ExtraText = "";
            this.Btn_Login.Values.Image = null;
            this.Btn_Login.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_Login.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_Login.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_Login.Values.Text = "ورود";
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_NewClerk
            // 
            this.Btn_NewClerk.Location = new System.Drawing.Point(65, 183);
            this.Btn_NewClerk.Name = "Btn_NewClerk";
            this.Btn_NewClerk.Size = new System.Drawing.Size(80, 25);
            this.Btn_NewClerk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewClerk.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewClerk.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewClerk.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewClerk.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewClerk.TabIndex = 3;
            this.Btn_NewClerk.Text = "کاربر جدید";
            this.Btn_NewClerk.Values.ExtraText = "";
            this.Btn_NewClerk.Values.Image = null;
            this.Btn_NewClerk.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_NewClerk.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_NewClerk.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_NewClerk.Values.Text = "کاربر جدید";
            this.Btn_NewClerk.Click += new System.EventHandler(this.Btn_NewClerk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Btn_Cancel);
            this.groupBox1.Controls.Add(this.Btn_Sabt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_repeat_newPassword);
            this.groupBox1.Controls.Add(this.txt_newPasword);
            this.groupBox1.Controls.Add(this.txt_newUsername);
            this.groupBox1.Location = new System.Drawing.Point(14, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعریف کاربر جدید";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(51, 107);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(80, 25);
            this.Btn_Cancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cancel.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.Values.ExtraText = "";
            this.Btn_Cancel.Values.Image = null;
            this.Btn_Cancel.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_Cancel.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_Cancel.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_Cancel.Values.Text = "لغو";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Sabt
            // 
            this.Btn_Sabt.Location = new System.Drawing.Point(137, 107);
            this.Btn_Sabt.Name = "Btn_Sabt";
            this.Btn_Sabt.Size = new System.Drawing.Size(80, 25);
            this.Btn_Sabt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Sabt.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Sabt.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Sabt.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Sabt.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Sabt.TabIndex = 8;
            this.Btn_Sabt.Text = "ثبت";
            this.Btn_Sabt.Values.ExtraText = "";
            this.Btn_Sabt.Values.Image = null;
            this.Btn_Sabt.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_Sabt.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_Sabt.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_Sabt.Values.Text = "ثبت";
            this.Btn_Sabt.Click += new System.EventHandler(this.Btn_Sabt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(191, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "کلمه عبور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(166, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "تکرار کلمه عبور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(189, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "نام کاربری";
            // 
            // txt_repeat_newPassword
            // 
            this.txt_repeat_newPassword.Location = new System.Drawing.Point(20, 76);
            this.txt_repeat_newPassword.Name = "txt_repeat_newPassword";
            this.txt_repeat_newPassword.PasswordChar = '*';
            this.txt_repeat_newPassword.Size = new System.Drawing.Size(140, 23);
            this.txt_repeat_newPassword.TabIndex = 7;
            // 
            // txt_newPasword
            // 
            this.txt_newPasword.Location = new System.Drawing.Point(20, 49);
            this.txt_newPasword.Name = "txt_newPasword";
            this.txt_newPasword.PasswordChar = '*';
            this.txt_newPasword.Size = new System.Drawing.Size(140, 23);
            this.txt_newPasword.TabIndex = 6;
            // 
            // txt_newUsername
            // 
            this.txt_newUsername.Location = new System.Drawing.Point(20, 22);
            this.txt_newUsername.Name = "txt_newUsername";
            this.txt_newUsername.Size = new System.Drawing.Size(140, 23);
            this.txt_newUsername.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(297, 221);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_NewClerk);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.Cmb_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Opacity = 0;
            this.ShowInTaskbar = true;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_NewClerk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_repeat_newPassword;
        private System.Windows.Forms.TextBox txt_newPasword;
        private System.Windows.Forms.TextBox txt_newUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Sabt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Cancel;
    }
}
