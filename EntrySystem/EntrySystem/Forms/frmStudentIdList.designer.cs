namespace EntrySystem.Forms
{
    partial class frmStudentIdList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentIdList));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDistrictInfoList = new System.Windows.Forms.GroupBox();
            this.grpSearchList = new System.Windows.Forms.GroupBox();
            this.lblSearchMsg = new System.Windows.Forms.Label();
            this.cmdCancelSearch = new System.Windows.Forms.Button();
            this.cmdGoSearch = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.lstStudentIDInfo = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picListRefresh = new System.Windows.Forms.PictureBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpDistrictInfoList.SuspendLayout();
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
            this.Panel1.Location = new System.Drawing.Point(2, 4);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(563, 61);
            this.Panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "List of Created Student ID";
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
            this.grpDistrictInfoList.Controls.Add(this.grpSearchList);
            this.grpDistrictInfoList.Controls.Add(this.lstStudentIDInfo);
            this.grpDistrictInfoList.Location = new System.Drawing.Point(6, 67);
            this.grpDistrictInfoList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDistrictInfoList.Name = "grpDistrictInfoList";
            this.grpDistrictInfoList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDistrictInfoList.Size = new System.Drawing.Size(884, 495);
            this.grpDistrictInfoList.TabIndex = 23;
            this.grpDistrictInfoList.TabStop = false;
            // 
            // grpSearchList
            // 
            this.grpSearchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpSearchList.Controls.Add(this.lblSearchMsg);
            this.grpSearchList.Controls.Add(this.cmdCancelSearch);
            this.grpSearchList.Controls.Add(this.cmdGoSearch);
            this.grpSearchList.Controls.Add(this.txtStudentId);
            this.grpSearchList.Controls.Add(this.Label5);
            this.grpSearchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSearchList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchList.Location = new System.Drawing.Point(260, 194);
            this.grpSearchList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchList.Name = "grpSearchList";
            this.grpSearchList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchList.Size = new System.Drawing.Size(364, 106);
            this.grpSearchList.TabIndex = 30;
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
            // txtStudentId
            // 
            this.txtStudentId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStudentId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(138, 33);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentId.MaxLength = 50;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(215, 21);
            this.txtStudentId.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(27, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Student Id :";
            // 
            // lstStudentIDInfo
            // 
            this.lstStudentIDInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstStudentIDInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudentIDInfo.FullRowSelect = true;
            this.lstStudentIDInfo.GridLines = true;
            this.lstStudentIDInfo.Location = new System.Drawing.Point(8, 17);
            this.lstStudentIDInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstStudentIDInfo.Name = "lstStudentIDInfo";
            this.lstStudentIDInfo.Size = new System.Drawing.Size(870, 471);
            this.lstStudentIDInfo.TabIndex = 1;
            this.lstStudentIDInfo.UseCompatibleStateImageBehavior = false;
            this.lstStudentIDInfo.View = System.Windows.Forms.View.Details;
            this.lstStudentIDInfo.Click += new System.EventHandler(this.lstStudentIDInfo_Click);
            this.lstStudentIDInfo.DoubleClick += new System.EventHandler(this.lstStudentIDInfo_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Student ID";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Registration No";
            this.columnHeader1.Width = 200;
            // 
            // picListRefresh
            // 
            this.picListRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picListRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picListRefresh.Image")));
            this.picListRefresh.Location = new System.Drawing.Point(570, 28);
            this.picListRefresh.Name = "picListRefresh";
            this.picListRefresh.Size = new System.Drawing.Size(42, 35);
            this.picListRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picListRefresh.TabIndex = 60;
            this.picListRefresh.TabStop = false;
            this.picListRefresh.Click += new System.EventHandler(this.picListRefresh_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Candidate Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Father Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DOB";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gender";
            // 
            // frmStudentIdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 567);
            this.Controls.Add(this.picListRefresh);
            this.Controls.Add(this.grpDistrictInfoList);
            this.Controls.Add(this.Panel1);
            this.Name = "frmStudentIdList";
            this.Text = "frmStudentIdList";
            this.Load += new System.EventHandler(this.frmStudentIdList_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpDistrictInfoList.ResumeLayout(false);
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
        internal System.Windows.Forms.ListView lstStudentIDInfo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        internal System.Windows.Forms.GroupBox grpSearchList;
        private System.Windows.Forms.Label lblSearchMsg;
        internal System.Windows.Forms.Button cmdCancelSearch;
        internal System.Windows.Forms.Button cmdGoSearch;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.PictureBox picListRefresh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}