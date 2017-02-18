namespace EntrySystem.Forms
{
    partial class UserMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMasterList));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDistrictInfoList = new System.Windows.Forms.GroupBox();
            this.grpChangePassword = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUserInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grpSearchList = new System.Windows.Forms.GroupBox();
            this.lblSearchMsg = new System.Windows.Forms.Label();
            this.cmdCancelSearch = new System.Windows.Forms.Button();
            this.cmdGoSearch = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picListRefresh = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpDistrictInfoList.SuspendLayout();
            this.grpChangePassword.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSearchList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(2, 3);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(563, 61);
            this.Panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "List of Users";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(2, 3);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 53);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // grpDistrictInfoList
            // 
            this.grpDistrictInfoList.Controls.Add(this.grpChangePassword);
            this.grpDistrictInfoList.Controls.Add(this.lstUserInfo);
            this.grpDistrictInfoList.Location = new System.Drawing.Point(4, 68);
            this.grpDistrictInfoList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDistrictInfoList.Name = "grpDistrictInfoList";
            this.grpDistrictInfoList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDistrictInfoList.Size = new System.Drawing.Size(884, 495);
            this.grpDistrictInfoList.TabIndex = 22;
            this.grpDistrictInfoList.TabStop = false;
            // 
            // grpChangePassword
            // 
            this.grpChangePassword.Controls.Add(this.groupBox1);
            this.grpChangePassword.Location = new System.Drawing.Point(315, 122);
            this.grpChangePassword.Name = "grpChangePassword";
            this.grpChangePassword.Size = new System.Drawing.Size(333, 234);
            this.grpChangePassword.TabIndex = 2;
            this.grpChangePassword.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtRetypePassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.txtOldPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(59, 201);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(239, 19);
            this.lblMsg.TabIndex = 92;
            this.lblMsg.Text = ".";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(94, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(10, 13);
            this.lblUserName.TabIndex = 91;
            this.lblUserName.Text = ".";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(189, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(83, 160);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "SUBMIT";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetypePassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.Location = new System.Drawing.Point(141, 125);
            this.txtRetypePassword.MaxLength = 30;
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(140, 22);
            this.txtRetypePassword.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(141, 97);
            this.txtNewPassword.MaxLength = 30;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(140, 22);
            this.txtNewPassword.TabIndex = 8;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(141, 69);
            this.txtOldPassword.MaxLength = 30;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(140, 22);
            this.txtOldPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Retype New Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "New Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old Password : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(95, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name : ";
            // 
            // btnUserName
            // 
            this.btnUserName.AutoSize = true;
            this.btnUserName.Location = new System.Drawing.Point(92, 27);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(0, 13);
            this.btnUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name : ";
            // 
            // lstUserInfo
            // 
            this.lstUserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstUserInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserInfo.FullRowSelect = true;
            this.lstUserInfo.GridLines = true;
            this.lstUserInfo.Location = new System.Drawing.Point(8, 17);
            this.lstUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUserInfo.Name = "lstUserInfo";
            this.lstUserInfo.Size = new System.Drawing.Size(870, 471);
            this.lstUserInfo.TabIndex = 1;
            this.lstUserInfo.UseCompatibleStateImageBehavior = false;
            this.lstUserInfo.View = System.Windows.Forms.View.Details;
            this.lstUserInfo.Click += new System.EventHandler(this.lstUserInfo_Click);
            this.lstUserInfo.DoubleClick += new System.EventHandler(this.lstUserInfo_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact No";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "User Role";
            this.columnHeader5.Width = 150;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(748, 40);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(131, 23);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // grpSearchList
            // 
            this.grpSearchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpSearchList.Controls.Add(this.lblSearchMsg);
            this.grpSearchList.Controls.Add(this.cmdCancelSearch);
            this.grpSearchList.Controls.Add(this.cmdGoSearch);
            this.grpSearchList.Controls.Add(this.txtSearchText);
            this.grpSearchList.Controls.Add(this.label7);
            this.grpSearchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSearchList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchList.Location = new System.Drawing.Point(260, 230);
            this.grpSearchList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchList.Name = "grpSearchList";
            this.grpSearchList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchList.Size = new System.Drawing.Size(364, 106);
            this.grpSearchList.TabIndex = 31;
            this.grpSearchList.TabStop = false;
            this.grpSearchList.Text = "Search ";
            this.grpSearchList.Visible = false;
            // 
            // lblSearchMsg
            // 
            this.lblSearchMsg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMsg.Location = new System.Drawing.Point(40, 72);
            this.lblSearchMsg.Name = "lblSearchMsg";
            this.lblSearchMsg.Size = new System.Drawing.Size(161, 18);
            this.lblSearchMsg.TabIndex = 13;
            // 
            // cmdCancelSearch
            // 
            this.cmdCancelSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelSearch.Location = new System.Drawing.Point(283, 67);
            this.cmdCancelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancelSearch.Name = "cmdCancelSearch";
            this.cmdCancelSearch.Size = new System.Drawing.Size(68, 30);
            this.cmdCancelSearch.TabIndex = 3;
            this.cmdCancelSearch.Text = "&Cancel";
            this.cmdCancelSearch.UseVisualStyleBackColor = true;
            this.cmdCancelSearch.Click += new System.EventHandler(this.cmdCancelSearch_Click);
            // 
            // cmdGoSearch
            // 
            this.cmdGoSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGoSearch.Location = new System.Drawing.Point(206, 67);
            this.cmdGoSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGoSearch.Name = "cmdGoSearch";
            this.cmdGoSearch.Size = new System.Drawing.Size(70, 30);
            this.cmdGoSearch.TabIndex = 2;
            this.cmdGoSearch.Text = "&GO";
            this.cmdGoSearch.UseVisualStyleBackColor = true;
            this.cmdGoSearch.Click += new System.EventHandler(this.cmdGoSearch_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(138, 33);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchText.MaxLength = 50;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(215, 21);
            this.txtSearchText.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Text :";
            // 
            // picListRefresh
            // 
            this.picListRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picListRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picListRefresh.Image")));
            this.picListRefresh.Location = new System.Drawing.Point(578, 29);
            this.picListRefresh.Name = "picListRefresh";
            this.picListRefresh.Size = new System.Drawing.Size(42, 35);
            this.picListRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picListRefresh.TabIndex = 61;
            this.picListRefresh.TabStop = false;
            this.picListRefresh.Click += new System.EventHandler(this.picListRefresh_Click);
            // 
            // UserMasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 571);
            this.Controls.Add(this.picListRefresh);
            this.Controls.Add(this.grpSearchList);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.grpDistrictInfoList);
            this.Controls.Add(this.Panel1);
            this.Name = "UserMasterList";
            this.Text = "User Master";
            this.Load += new System.EventHandler(this.UserMasterList_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpDistrictInfoList.ResumeLayout(false);
            this.grpChangePassword.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSearchList.ResumeLayout(false);
            this.grpSearchList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.GroupBox grpDistrictInfoList;
        internal System.Windows.Forms.ListView lstUserInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel grpChangePassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblMsg;
        internal System.Windows.Forms.GroupBox grpSearchList;
        private System.Windows.Forms.Label lblSearchMsg;
        internal System.Windows.Forms.Button cmdCancelSearch;
        internal System.Windows.Forms.Button cmdGoSearch;
        internal System.Windows.Forms.TextBox txtSearchText;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picListRefresh;
    }
}