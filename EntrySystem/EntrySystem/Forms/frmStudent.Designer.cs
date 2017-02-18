namespace EntrySystem.Forms
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGetRegistrationNo = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetStudentID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ddlElectiveSubject = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ddlLIUESubject = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ddlMILGroup = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ddlMILSubject = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ddlMediumOfExam = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ddlAnnualFamilyIncome = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlTypeOfChallange = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlPhysicallyChallange = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegNo5 = new System.Windows.Forms.TextBox();
            this.txtRegNo4 = new System.Windows.Forms.TextBox();
            this.txtRegNo3 = new System.Windows.Forms.TextBox();
            this.txtRegNo2 = new System.Windows.Forms.TextBox();
            this.txtRegNo1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnameOfStudent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlNatureOfEntry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGetRegistrationNo);
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGetStudentID);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 58);
            this.panel1.TabIndex = 45;
            // 
            // txtGetRegistrationNo
            // 
            this.txtGetRegistrationNo.AcceptsReturn = true;
            this.txtGetRegistrationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetRegistrationNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetRegistrationNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetRegistrationNo.Location = new System.Drawing.Point(122, 7);
            this.txtGetRegistrationNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGetRegistrationNo.MaxLength = 17;
            this.txtGetRegistrationNo.Name = "txtGetRegistrationNo";
            this.txtGetRegistrationNo.Size = new System.Drawing.Size(169, 23);
            this.txtGetRegistrationNo.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetData.Location = new System.Drawing.Point(301, 2);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(73, 33);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Registration No";
            // 
            // txtGetStudentID
            // 
            this.txtGetStudentID.AcceptsReturn = true;
            this.txtGetStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetStudentID.Location = new System.Drawing.Point(121, 33);
            this.txtGetStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGetStudentID.MaxLength = 13;
            this.txtGetStudentID.Name = "txtGetStudentID";
            this.txtGetStudentID.Size = new System.Drawing.Size(169, 23);
            this.txtGetStudentID.TabIndex = 0;
            this.txtGetStudentID.Visible = false;
            this.txtGetStudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGetStudentID_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label52);
            this.panel2.Controls.Add(this.txtDOB);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.ddlElectiveSubject);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.ddlLIUESubject);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.ddlMILGroup);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.ddlMILSubject);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.ddlMediumOfExam);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ddlAnnualFamilyIncome);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.ddlTypeOfChallange);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ddlPhysicallyChallange);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ddlCategory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ddlGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMotherName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFatherName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRegNo5);
            this.panel2.Controls.Add(this.txtRegNo4);
            this.panel2.Controls.Add(this.txtRegNo3);
            this.panel2.Controls.Add(this.txtRegNo2);
            this.panel2.Controls.Add(this.txtRegNo1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtnameOfStudent);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ddlNatureOfEntry);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtStudentID);
            this.panel2.Location = new System.Drawing.Point(4, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 476);
            this.panel2.TabIndex = 53;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label52.Location = new System.Drawing.Point(278, 199);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(86, 17);
            this.label52.TabIndex = 150;
            this.label52.Text = "(ddmmyyyy)";
            // 
            // txtDOB
            // 
            this.txtDOB.AcceptsReturn = true;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(161, 195);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDOB.MaxLength = 8;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(110, 23);
            this.txtDOB.TabIndex = 12;
            this.txtDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDOB_KeyDown);
            this.txtDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOB_KeyPress);
            this.txtDOB.Leave += new System.EventHandler(this.txtDOB_Leave);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AcceptsReturn = true;
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(161, 371);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemarks.MaxLength = 40;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(370, 47);
            this.txtRemarks.TabIndex = 17;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemarks_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 371);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 89;
            this.label19.Text = "Remarks";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(882, 433);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 25;
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
            this.btnSave.Location = new System.Drawing.Point(778, 433);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "SUBMIT";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(562, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 86;
            this.label17.Text = "Elective Subject ";
            // 
            // ddlElectiveSubject
            // 
            this.ddlElectiveSubject.BackColor = System.Drawing.SystemColors.Window;
            this.ddlElectiveSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlElectiveSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlElectiveSubject.FormattingEnabled = true;
            this.ddlElectiveSubject.Location = new System.Drawing.Point(730, 330);
            this.ddlElectiveSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlElectiveSubject.Name = "ddlElectiveSubject";
            this.ddlElectiveSubject.Size = new System.Drawing.Size(226, 23);
            this.ddlElectiveSubject.TabIndex = 23;
            this.ddlElectiveSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlElectiveSubject_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(562, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 17);
            this.label18.TabIndex = 84;
            this.label18.Text = "LIEU Subject";
            // 
            // ddlLIUESubject
            // 
            this.ddlLIUESubject.BackColor = System.Drawing.SystemColors.Window;
            this.ddlLIUESubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLIUESubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLIUESubject.FormattingEnabled = true;
            this.ddlLIUESubject.Location = new System.Drawing.Point(730, 296);
            this.ddlLIUESubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlLIUESubject.Name = "ddlLIUESubject";
            this.ddlLIUESubject.Size = new System.Drawing.Size(226, 23);
            this.ddlLIUESubject.TabIndex = 22;
            this.ddlLIUESubject.SelectedIndexChanged += new System.EventHandler(this.ddlLIUESubject_SelectedIndexChanged);
            this.ddlLIUESubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlLIUESubject_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(562, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 82;
            this.label16.Text = "MIL Group ";
            // 
            // ddlMILGroup
            // 
            this.ddlMILGroup.BackColor = System.Drawing.SystemColors.Window;
            this.ddlMILGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMILGroup.Enabled = false;
            this.ddlMILGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMILGroup.FormattingEnabled = true;
            this.ddlMILGroup.Items.AddRange(new object[] {
            "--Select--",
            "A+B",
            "A+C"});
            this.ddlMILGroup.Location = new System.Drawing.Point(730, 256);
            this.ddlMILGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlMILGroup.Name = "ddlMILGroup";
            this.ddlMILGroup.Size = new System.Drawing.Size(226, 23);
            this.ddlMILGroup.TabIndex = 21;
            this.ddlMILGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlMILGroup_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "MIL Subject";
            // 
            // ddlMILSubject
            // 
            this.ddlMILSubject.BackColor = System.Drawing.SystemColors.Window;
            this.ddlMILSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMILSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMILSubject.FormattingEnabled = true;
            this.ddlMILSubject.Location = new System.Drawing.Point(730, 226);
            this.ddlMILSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlMILSubject.Name = "ddlMILSubject";
            this.ddlMILSubject.Size = new System.Drawing.Size(226, 23);
            this.ddlMILSubject.TabIndex = 20;
            this.ddlMILSubject.SelectedIndexChanged += new System.EventHandler(this.ddlMILSubject_SelectedIndexChanged);
            this.ddlMILSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlMILSubject_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Medium of Examination";
            // 
            // ddlMediumOfExam
            // 
            this.ddlMediumOfExam.BackColor = System.Drawing.SystemColors.Window;
            this.ddlMediumOfExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMediumOfExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMediumOfExam.FormattingEnabled = true;
            this.ddlMediumOfExam.Items.AddRange(new object[] {
            "--Select--",
            "ASSAMESE",
            "BENGALI",
            "BODO",
            "ENGLISH",
            "HINDI",
            "MANIPURI"});
            this.ddlMediumOfExam.Location = new System.Drawing.Point(730, 191);
            this.ddlMediumOfExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlMediumOfExam.Name = "ddlMediumOfExam";
            this.ddlMediumOfExam.Size = new System.Drawing.Size(226, 23);
            this.ddlMediumOfExam.TabIndex = 19;
            this.ddlMediumOfExam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlMediumOfExam_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(560, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(246, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "Annaul Family income is upto Rs 1 Lac";
            // 
            // ddlAnnualFamilyIncome
            // 
            this.ddlAnnualFamilyIncome.BackColor = System.Drawing.SystemColors.Window;
            this.ddlAnnualFamilyIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAnnualFamilyIncome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAnnualFamilyIncome.FormattingEnabled = true;
            this.ddlAnnualFamilyIncome.Items.AddRange(new object[] {
            "--Select--",
            "YES",
            "NO"});
            this.ddlAnnualFamilyIncome.Location = new System.Drawing.Point(812, 159);
            this.ddlAnnualFamilyIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlAnnualFamilyIncome.Name = "ddlAnnualFamilyIncome";
            this.ddlAnnualFamilyIncome.Size = new System.Drawing.Size(112, 23);
            this.ddlAnnualFamilyIncome.TabIndex = 18;
            this.ddlAnnualFamilyIncome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlAnnualFamilyIncome_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 74;
            this.label12.Text = "Type of Challenge";
            // 
            // ddlTypeOfChallange
            // 
            this.ddlTypeOfChallange.BackColor = System.Drawing.SystemColors.Window;
            this.ddlTypeOfChallange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTypeOfChallange.Enabled = false;
            this.ddlTypeOfChallange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTypeOfChallange.FormattingEnabled = true;
            this.ddlTypeOfChallange.Items.AddRange(new object[] {
            "--Select--",
            "SPEECH IMPAIRED",
            "HEARING IMPAIRED",
            "VISUALLY IMPAIRED",
            "ORTHOPEDICALLY IMPAIRED"});
            this.ddlTypeOfChallange.Location = new System.Drawing.Point(161, 329);
            this.ddlTypeOfChallange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlTypeOfChallange.Name = "ddlTypeOfChallange";
            this.ddlTypeOfChallange.Size = new System.Drawing.Size(226, 23);
            this.ddlTypeOfChallange.TabIndex = 16;
            this.ddlTypeOfChallange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlTypeOfChallange_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Physically Challenged";
            // 
            // ddlPhysicallyChallange
            // 
            this.ddlPhysicallyChallange.BackColor = System.Drawing.SystemColors.Window;
            this.ddlPhysicallyChallange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPhysicallyChallange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPhysicallyChallange.FormattingEnabled = true;
            this.ddlPhysicallyChallange.Items.AddRange(new object[] {
            "--Select--",
            "YES",
            "NO"});
            this.ddlPhysicallyChallange.Location = new System.Drawing.Point(161, 298);
            this.ddlPhysicallyChallange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlPhysicallyChallange.Name = "ddlPhysicallyChallange";
            this.ddlPhysicallyChallange.Size = new System.Drawing.Size(112, 23);
            this.ddlPhysicallyChallange.TabIndex = 15;
            this.ddlPhysicallyChallange.SelectedIndexChanged += new System.EventHandler(this.ddlPhysicallyChallange_SelectedIndexChanged);
            this.ddlPhysicallyChallange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlPhysicallyChallange_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Category (caste)";
            // 
            // ddlCategory
            // 
            this.ddlCategory.BackColor = System.Drawing.SystemColors.Window;
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Items.AddRange(new object[] {
            "--Select--",
            "GEN",
            "TG",
            "SC",
            "OBC",
            "ST(P)",
            "MOBC",
            "ST(H)"});
            this.ddlCategory.Location = new System.Drawing.Point(161, 260);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(210, 23);
            this.ddlCategory.TabIndex = 14;
            this.ddlCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlCategory_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Gender";
            // 
            // ddlGender
            // 
            this.ddlGender.BackColor = System.Drawing.SystemColors.Window;
            this.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.Items.AddRange(new object[] {
            "--Select--",
            "MALE",
            "FEMALE"});
            this.ddlGender.Location = new System.Drawing.Point(161, 229);
            this.ddlGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(112, 23);
            this.ddlGender.TabIndex = 13;
            this.ddlGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlGender_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Date of Birth";
            // 
            // txtMotherName
            // 
            this.txtMotherName.AcceptsReturn = true;
            this.txtMotherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotherName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotherName.Location = new System.Drawing.Point(161, 161);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotherName.MaxLength = 40;
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(345, 23);
            this.txtMotherName.TabIndex = 11;
            this.txtMotherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMotherName_KeyDown);
            this.txtMotherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotherName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mother\'s Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.AcceptsReturn = true;
            this.txtFatherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(161, 130);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFatherName.MaxLength = 40;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(345, 23);
            this.txtFatherName.TabIndex = 10;
            this.txtFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFatherName_KeyDown);
            this.txtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Father\'s Name";
            // 
            // txtRegNo5
            // 
            this.txtRegNo5.AcceptsReturn = true;
            this.txtRegNo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegNo5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo5.Location = new System.Drawing.Point(509, 89);
            this.txtRegNo5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegNo5.MaxLength = 2;
            this.txtRegNo5.Name = "txtRegNo5";
            this.txtRegNo5.Size = new System.Drawing.Size(96, 23);
            this.txtRegNo5.TabIndex = 9;
            this.txtRegNo5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegNo5_KeyDown);
            this.txtRegNo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo5_KeyPress);
            // 
            // txtRegNo4
            // 
            this.txtRegNo4.AcceptsReturn = true;
            this.txtRegNo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegNo4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo4.Location = new System.Drawing.Point(413, 89);
            this.txtRegNo4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegNo4.MaxLength = 6;
            this.txtRegNo4.Name = "txtRegNo4";
            this.txtRegNo4.Size = new System.Drawing.Size(93, 23);
            this.txtRegNo4.TabIndex = 8;
            this.txtRegNo4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegNo4_KeyDown);
            this.txtRegNo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo4_KeyPress);
            // 
            // txtRegNo3
            // 
            this.txtRegNo3.AcceptsReturn = true;
            this.txtRegNo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegNo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo3.Location = new System.Drawing.Point(316, 89);
            this.txtRegNo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegNo3.MaxLength = 4;
            this.txtRegNo3.Name = "txtRegNo3";
            this.txtRegNo3.Size = new System.Drawing.Size(94, 23);
            this.txtRegNo3.TabIndex = 7;
            this.txtRegNo3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegNo3_KeyDown);
            this.txtRegNo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo3_KeyPress);
            // 
            // txtRegNo2
            // 
            this.txtRegNo2.AcceptsReturn = true;
            this.txtRegNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegNo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo2.Location = new System.Drawing.Point(239, 89);
            this.txtRegNo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegNo2.MaxLength = 20;
            this.txtRegNo2.Name = "txtRegNo2";
            this.txtRegNo2.Size = new System.Drawing.Size(74, 23);
            this.txtRegNo2.TabIndex = 6;
            this.txtRegNo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegNo2_KeyDown);
            this.txtRegNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo2_KeyPress);
            // 
            // txtRegNo1
            // 
            this.txtRegNo1.AcceptsReturn = true;
            this.txtRegNo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegNo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo1.Location = new System.Drawing.Point(161, 89);
            this.txtRegNo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegNo1.MaxLength = 2;
            this.txtRegNo1.Name = "txtRegNo1";
            this.txtRegNo1.Size = new System.Drawing.Size(75, 23);
            this.txtRegNo1.TabIndex = 5;
            this.txtRegNo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegNo1_KeyDown);
            this.txtRegNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Registration Number";
            // 
            // txtnameOfStudent
            // 
            this.txtnameOfStudent.AcceptsReturn = true;
            this.txtnameOfStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnameOfStudent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnameOfStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameOfStudent.Location = new System.Drawing.Point(161, 48);
            this.txtnameOfStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnameOfStudent.MaxLength = 40;
            this.txtnameOfStudent.Name = "txtnameOfStudent";
            this.txtnameOfStudent.Size = new System.Drawing.Size(345, 23);
            this.txtnameOfStudent.TabIndex = 4;
            this.txtnameOfStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnameOfStudent_KeyDown);
            this.txtnameOfStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnameOfStudent_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Name of Student";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Nature of Entry";
            // 
            // ddlNatureOfEntry
            // 
            this.ddlNatureOfEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNatureOfEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlNatureOfEntry.FormattingEnabled = true;
            this.ddlNatureOfEntry.Location = new System.Drawing.Point(746, 16);
            this.ddlNatureOfEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlNatureOfEntry.Name = "ddlNatureOfEntry";
            this.ddlNatureOfEntry.Size = new System.Drawing.Size(210, 23);
            this.ddlNatureOfEntry.TabIndex = 3;
            this.ddlNatureOfEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlNatureOfEntry_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.AcceptsReturn = true;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(161, 13);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.MaxLength = 13;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(169, 23);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(556, 36);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(285, 17);
            this.lblMsg.TabIndex = 54;
            this.lblMsg.Text = ".";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 546);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetStudentID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnameOfStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlNatureOfEntry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtRegNo5;
        private System.Windows.Forms.TextBox txtRegNo4;
        private System.Windows.Forms.TextBox txtRegNo3;
        private System.Windows.Forms.TextBox txtRegNo2;
        private System.Windows.Forms.TextBox txtRegNo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlPhysicallyChallange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlTypeOfChallange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ddlMediumOfExam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddlAnnualFamilyIncome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ddlMILSubject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddlMILGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ddlElectiveSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ddlLIUESubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtGetRegistrationNo;

    }
}