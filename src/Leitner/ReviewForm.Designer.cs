namespace Leitner
{
    partial class ReviewForm
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
            this.components = new System.ComponentModel.Container();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.englishWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordSituationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblWordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_Meaning = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.englishWordDataGridViewTextBoxColumn,
            this.persianWordDataGridViewTextBoxColumn,
            this.insertDateDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.wordSituationDataGridViewTextBoxColumn,
            this.tblUserDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.tblWordBindingSource;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView.Size = new System.Drawing.Size(421, 402);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 26;
            // 
            // englishWordDataGridViewTextBoxColumn
            // 
            this.englishWordDataGridViewTextBoxColumn.DataPropertyName = "English_Word";
            this.englishWordDataGridViewTextBoxColumn.HeaderText = "لغت انگلیسی";
            this.englishWordDataGridViewTextBoxColumn.Name = "englishWordDataGridViewTextBoxColumn";
            this.englishWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.englishWordDataGridViewTextBoxColumn.Width = 99;
            // 
            // persianWordDataGridViewTextBoxColumn
            // 
            this.persianWordDataGridViewTextBoxColumn.DataPropertyName = "Persian_Word";
            this.persianWordDataGridViewTextBoxColumn.HeaderText = "معنی فارسی";
            this.persianWordDataGridViewTextBoxColumn.Name = "persianWordDataGridViewTextBoxColumn";
            this.persianWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.persianWordDataGridViewTextBoxColumn.Width = 98;
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            this.insertDateDataGridViewTextBoxColumn.DataPropertyName = "Insert_Date";
            this.insertDateDataGridViewTextBoxColumn.HeaderText = "Insert_Date";
            this.insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            this.insertDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.insertDateDataGridViewTextBoxColumn.Visible = false;
            this.insertDateDataGridViewTextBoxColumn.Width = 92;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            this.userNameDataGridViewTextBoxColumn.Width = 89;
            // 
            // wordSituationDataGridViewTextBoxColumn
            // 
            this.wordSituationDataGridViewTextBoxColumn.DataPropertyName = "Word_Situation";
            this.wordSituationDataGridViewTextBoxColumn.HeaderText = "Word_Situation";
            this.wordSituationDataGridViewTextBoxColumn.Name = "wordSituationDataGridViewTextBoxColumn";
            this.wordSituationDataGridViewTextBoxColumn.ReadOnly = true;
            this.wordSituationDataGridViewTextBoxColumn.Visible = false;
            this.wordSituationDataGridViewTextBoxColumn.Width = 108;
            // 
            // tblUserDataGridViewTextBoxColumn
            // 
            this.tblUserDataGridViewTextBoxColumn.DataPropertyName = "Tbl_User";
            this.tblUserDataGridViewTextBoxColumn.HeaderText = "Tbl_User";
            this.tblUserDataGridViewTextBoxColumn.Name = "tblUserDataGridViewTextBoxColumn";
            this.tblUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.tblUserDataGridViewTextBoxColumn.Visible = false;
            this.tblUserDataGridViewTextBoxColumn.Width = 76;
            // 
            // tblWordBindingSource
            // 
            this.tblWordBindingSource.DataSource = typeof(Leitner.Tbl_Word);
            // 
            // Btn_Meaning
            // 
            this.Btn_Meaning.Checked = true;
            this.Btn_Meaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Meaning.Location = new System.Drawing.Point(0, 402);
            this.Btn_Meaning.Name = "Btn_Meaning";
            this.Btn_Meaning.Size = new System.Drawing.Size(421, 33);
            this.Btn_Meaning.StateCheckedNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateCheckedNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateCheckedPressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateCheckedPressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateCheckedTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateCheckedTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateDisabled.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.Btn_Meaning.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Meaning.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Meaning.TabIndex = 27;
            this.Btn_Meaning.Text = "مشاهده معنی";
            this.Btn_Meaning.Values.ExtraText = "";
            this.Btn_Meaning.Values.Image = null;
            this.Btn_Meaning.Values.Text = "مشاهده معنی";
            this.Btn_Meaning.Click += new System.EventHandler(this.Btn_Meaning_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(421, 435);
            this.Controls.Add(this.Btn_Meaning);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReviewForm";
            this.Opacity = 0;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Text = "لغات خوانده نشده";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.Shown += new System.EventHandler(this.ReviewForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton Btn_Meaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordSituationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblWordBindingSource;
    }
}
