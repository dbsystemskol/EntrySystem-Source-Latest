namespace EntrySystem.Forms
{
    partial class frmVerifyStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPendingClose = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Col_Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPendingview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVerifiedStatus = new System.Windows.Forms.Label();
            this.btnUnverifyClose = new System.Windows.Forms.Button();
            this.btnUnVerify = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVerifiedRecordCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVerifiedResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVerifiedView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkVerifiedSelectAll = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerifiedRecordSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerifiedSearchText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifiedResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(22, 610);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 28);
            this.btnUpdate.TabIndex = 252;
            this.btnUpdate.Text = "Update Student Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1294, 601);
            this.tabControl1.TabIndex = 253;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.btnPendingClose);
            this.tabPage1.Controls.Add(this.btnVerify);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.GroupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1286, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(506, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(14, 16);
            this.lblStatus.TabIndex = 254;
            this.lblStatus.Text = "..";
            // 
            // btnPendingClose
            // 
            this.btnPendingClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnPendingClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingClose.Location = new System.Drawing.Point(629, 536);
            this.btnPendingClose.Name = "btnPendingClose";
            this.btnPendingClose.Size = new System.Drawing.Size(98, 28);
            this.btnPendingClose.TabIndex = 253;
            this.btnPendingClose.Text = "Close";
            this.btnPendingClose.UseVisualStyleBackColor = false;
            this.btnPendingClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(502, 536);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(115, 28);
            this.btnVerify.TabIndex = 252;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecord);
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Controls.Add(this.chkSelectAll);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1302, 466);
            this.groupBox1.TabIndex = 249;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Result";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(734, 4);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(12, 17);
            this.lblRecord.TabIndex = 248;
            this.lblRecord.Text = ".";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResult.ColumnHeadersHeight = 40;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Select,
            this.Column1,
            this.Column4,
            this.MemName,
            this.col_Name,
            this.Column5,
            this.clmPendingview});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResult.Location = new System.Drawing.Point(10, 22);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1281, 437);
            this.dgvResult.TabIndex = 247;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // Col_Select
            // 
            this.Col_Select.HeaderText = "";
            this.Col_Select.Name = "Col_Select";
            this.Col_Select.Width = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nature of entry";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Student ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // MemName
            // 
            this.MemName.HeaderText = "Registration No";
            this.MemName.Name = "MemName";
            this.MemName.ReadOnly = true;
            this.MemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemName.Width = 150;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            this.col_Name.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Birth date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // clmPendingview
            // 
            this.clmPendingview.DataPropertyName = "View";
            this.clmPendingview.HeaderText = "View";
            this.clmPendingview.Name = "clmPendingview";
            this.clmPendingview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPendingview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmPendingview.Text = "View";
            this.clmPendingview.UseColumnTextForButtonValue = true;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.Location = new System.Drawing.Point(129, 0);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(79, 21);
            this.chkSelectAll.TabIndex = 246;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtSearchText);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(15, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(449, 63);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search Parameters";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(370, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 28);
            this.btnSearch.TabIndex = 245;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(16, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 17);
            this.Label2.TabIndex = 233;
            this.Label2.Text = "Registration No";
            // 
            // txtSearchText
            // 
            this.txtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(121, 26);
            this.txtSearchText.MaxLength = 50;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(240, 25);
            this.txtSearchText.TabIndex = 232;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblVerifiedStatus);
            this.tabPage2.Controls.Add(this.btnUnverifyClose);
            this.tabPage2.Controls.Add(this.btnUnVerify);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1286, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verified";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVerifiedStatus
            // 
            this.lblVerifiedStatus.AutoSize = true;
            this.lblVerifiedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifiedStatus.ForeColor = System.Drawing.Color.Red;
            this.lblVerifiedStatus.Location = new System.Drawing.Point(510, 34);
            this.lblVerifiedStatus.Name = "lblVerifiedStatus";
            this.lblVerifiedStatus.Size = new System.Drawing.Size(14, 16);
            this.lblVerifiedStatus.TabIndex = 256;
            this.lblVerifiedStatus.Text = "..";
            // 
            // btnUnverifyClose
            // 
            this.btnUnverifyClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnUnverifyClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnverifyClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnverifyClose.Location = new System.Drawing.Point(639, 538);
            this.btnUnverifyClose.Name = "btnUnverifyClose";
            this.btnUnverifyClose.Size = new System.Drawing.Size(98, 28);
            this.btnUnverifyClose.TabIndex = 255;
            this.btnUnverifyClose.Text = "Close";
            this.btnUnverifyClose.UseVisualStyleBackColor = false;
            this.btnUnverifyClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUnVerify
            // 
            this.btnUnVerify.BackColor = System.Drawing.SystemColors.Window;
            this.btnUnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnVerify.Location = new System.Drawing.Point(512, 538);
            this.btnUnVerify.Name = "btnUnVerify";
            this.btnUnVerify.Size = new System.Drawing.Size(115, 28);
            this.btnUnVerify.TabIndex = 254;
            this.btnUnVerify.Text = "Unverify";
            this.btnUnVerify.UseVisualStyleBackColor = false;
            this.btnUnVerify.Click += new System.EventHandler(this.btnUnVerify_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblVerifiedRecordCount);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dgvVerifiedResult);
            this.groupBox4.Controls.Add(this.chkVerifiedSelectAll);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1302, 466);
            this.groupBox4.TabIndex = 250;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Result";
            // 
            // lblVerifiedRecordCount
            // 
            this.lblVerifiedRecordCount.AutoSize = true;
            this.lblVerifiedRecordCount.Location = new System.Drawing.Point(689, 0);
            this.lblVerifiedRecordCount.Name = "lblVerifiedRecordCount";
            this.lblVerifiedRecordCount.Size = new System.Drawing.Size(12, 17);
            this.lblVerifiedRecordCount.TabIndex = 249;
            this.lblVerifiedRecordCount.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 248;
            // 
            // dgvVerifiedResult
            // 
            this.dgvVerifiedResult.AllowUserToAddRows = false;
            this.dgvVerifiedResult.AllowUserToDeleteRows = false;
            this.dgvVerifiedResult.AllowUserToResizeColumns = false;
            this.dgvVerifiedResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerifiedResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVerifiedResult.ColumnHeadersHeight = 40;
            this.dgvVerifiedResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.clmVerifiedView});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerifiedResult.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVerifiedResult.Location = new System.Drawing.Point(10, 22);
            this.dgvVerifiedResult.Name = "dgvVerifiedResult";
            this.dgvVerifiedResult.Size = new System.Drawing.Size(1281, 437);
            this.dgvVerifiedResult.TabIndex = 247;
            this.dgvVerifiedResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerifiedResult_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nature of entry";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Registration No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Birth date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // clmVerifiedView
            // 
            this.clmVerifiedView.DataPropertyName = "View";
            this.clmVerifiedView.HeaderText = "View";
            this.clmVerifiedView.Name = "clmVerifiedView";
            this.clmVerifiedView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmVerifiedView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmVerifiedView.Text = "View";
            this.clmVerifiedView.UseColumnTextForButtonValue = true;
            // 
            // chkVerifiedSelectAll
            // 
            this.chkVerifiedSelectAll.AutoSize = true;
            this.chkVerifiedSelectAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerifiedSelectAll.Location = new System.Drawing.Point(129, 0);
            this.chkVerifiedSelectAll.Name = "chkVerifiedSelectAll";
            this.chkVerifiedSelectAll.Size = new System.Drawing.Size(94, 21);
            this.chkVerifiedSelectAll.TabIndex = 246;
            this.chkVerifiedSelectAll.Text = "Deselect All";
            this.chkVerifiedSelectAll.UseVisualStyleBackColor = true;
            this.chkVerifiedSelectAll.CheckedChanged += new System.EventHandler(this.chkVerifiedSelectAll_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerifiedRecordSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtVerifiedSearchText);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Parameters";
            // 
            // btnVerifiedRecordSearch
            // 
            this.btnVerifiedRecordSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerifiedRecordSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifiedRecordSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifiedRecordSearch.Location = new System.Drawing.Point(370, 25);
            this.btnVerifiedRecordSearch.Name = "btnVerifiedRecordSearch";
            this.btnVerifiedRecordSearch.Size = new System.Drawing.Size(67, 28);
            this.btnVerifiedRecordSearch.TabIndex = 245;
            this.btnVerifiedRecordSearch.Text = "&Search";
            this.btnVerifiedRecordSearch.UseVisualStyleBackColor = false;
            this.btnVerifiedRecordSearch.Click += new System.EventHandler(this.btnVerifiedRecordSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 233;
            this.label1.Text = "Registration No";
            // 
            // txtVerifiedSearchText
            // 
            this.txtVerifiedSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerifiedSearchText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVerifiedSearchText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifiedSearchText.Location = new System.Drawing.Point(121, 26);
            this.txtVerifiedSearchText.MaxLength = 50;
            this.txtVerifiedSearchText.Name = "txtVerifiedSearchText";
            this.txtVerifiedSearchText.Size = new System.Drawing.Size(240, 25);
            this.txtVerifiedSearchText.TabIndex = 232;
            // 
            // frmVerifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 610);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmVerifyStudent";
            this.Text = "Verify Students";
            this.Load += new System.EventHandler(this.frmVerifyStudent_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifiedResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.Button btnPendingClose;
        internal System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecord;
        internal System.Windows.Forms.DataGridView dgvResult;
        internal System.Windows.Forms.CheckBox chkSelectAll;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnVerifiedRecordSearch;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtVerifiedSearchText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView dgvVerifiedResult;
        internal System.Windows.Forms.CheckBox chkVerifiedSelectAll;
        internal System.Windows.Forms.Button btnUnverifyClose;
        internal System.Windows.Forms.Button btnUnVerify;
        private System.Windows.Forms.Label lblVerifiedRecordCount;
        private System.Windows.Forms.Label lblVerifiedStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn clmPendingview;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn clmVerifiedView;
    }
}