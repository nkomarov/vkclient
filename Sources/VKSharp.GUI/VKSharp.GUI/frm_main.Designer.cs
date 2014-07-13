namespace VKSharp.GUI {
    partial class frm_main {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbAudiolist = new System.Windows.Forms.GroupBox();
            this.lblDownSelected = new System.Windows.Forms.Label();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.checkAudioList = new System.Windows.Forms.CheckedListBox();
            this.gbSaveTo = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnDownStart = new System.Windows.Forms.Button();
            this.dlgSaveTo = new System.Windows.Forms.FolderBrowserDialog();
            this.gbLogin.SuspendLayout();
            this.gbAudiolist.SuspendLayout();
            this.gbSaveTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.txtToken);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(609, 53);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "oAuth token:";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Location = new System.Drawing.Point(6, 21);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(515, 20);
            this.txtToken.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(528, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbAudiolist
            // 
            this.gbAudiolist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAudiolist.Controls.Add(this.lblDownSelected);
            this.gbAudiolist.Controls.Add(this.lblSelectedItems);
            this.gbAudiolist.Controls.Add(this.btnSelectNone);
            this.gbAudiolist.Controls.Add(this.btnSelectAll);
            this.gbAudiolist.Controls.Add(this.checkAudioList);
            this.gbAudiolist.Location = new System.Drawing.Point(12, 71);
            this.gbAudiolist.Name = "gbAudiolist";
            this.gbAudiolist.Size = new System.Drawing.Size(609, 243);
            this.gbAudiolist.TabIndex = 1;
            this.gbAudiolist.TabStop = false;
            this.gbAudiolist.Text = "Audio list:";
            // 
            // lblDownSelected
            // 
            this.lblDownSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownSelected.AutoSize = true;
            this.lblDownSelected.Location = new System.Drawing.Point(456, 219);
            this.lblDownSelected.Name = "lblDownSelected";
            this.lblDownSelected.Size = new System.Drawing.Size(147, 13);
            this.lblDownSelected.TabIndex = 3;
            this.lblDownSelected.Text = "Downloading 00000 of 00000";
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(320, 219);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(127, 13);
            this.lblSelectedItems.TabIndex = 2;
            this.lblSelectedItems.Text = "Selected 00000 of 00000";
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectNone.Location = new System.Drawing.Point(87, 214);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 1;
            this.btnSelectNone.Text = "Select none";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(6, 214);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // checkAudioList
            // 
            this.checkAudioList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAudioList.FormattingEnabled = true;
            this.checkAudioList.Location = new System.Drawing.Point(6, 19);
            this.checkAudioList.Name = "checkAudioList";
            this.checkAudioList.Size = new System.Drawing.Size(597, 184);
            this.checkAudioList.TabIndex = 0;
            this.checkAudioList.SelectedIndexChanged += new System.EventHandler(this.checkAudioList_SelectedIndexChanged);
            // 
            // gbSaveTo
            // 
            this.gbSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSaveTo.Controls.Add(this.btnBrowse);
            this.gbSaveTo.Controls.Add(this.txtSavePath);
            this.gbSaveTo.Controls.Add(this.btnDownStart);
            this.gbSaveTo.Location = new System.Drawing.Point(12, 320);
            this.gbSaveTo.Name = "gbSaveTo";
            this.gbSaveTo.Size = new System.Drawing.Size(609, 57);
            this.gbSaveTo.TabIndex = 2;
            this.gbSaveTo.TabStop = false;
            this.gbSaveTo.Text = "Save to:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(6, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(71, 21);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(451, 20);
            this.txtSavePath.TabIndex = 3;
            // 
            // btnDownStart
            // 
            this.btnDownStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownStart.Location = new System.Drawing.Point(528, 19);
            this.btnDownStart.Name = "btnDownStart";
            this.btnDownStart.Size = new System.Drawing.Size(75, 23);
            this.btnDownStart.TabIndex = 2;
            this.btnDownStart.Text = "Start";
            this.btnDownStart.UseVisualStyleBackColor = true;
            this.btnDownStart.Click += new System.EventHandler(this.btnDownStart_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 389);
            this.Controls.Add(this.gbSaveTo);
            this.Controls.Add(this.gbAudiolist);
            this.Controls.Add(this.gbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKSharp.GUI";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbAudiolist.ResumeLayout(false);
            this.gbAudiolist.PerformLayout();
            this.gbSaveTo.ResumeLayout(false);
            this.gbSaveTo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbAudiolist;
        private System.Windows.Forms.CheckedListBox checkAudioList;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox gbSaveTo;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnDownStart;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.Label lblDownSelected;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog dlgSaveTo;
    }
}

