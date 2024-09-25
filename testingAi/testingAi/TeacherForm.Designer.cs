namespace testingAi
{
    partial class TeacherForm
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
            lblTeacherId = new Label();
            txtTeacherId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDiscipline = new Label();
            txtDiscipline = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            chkIsAdministrator = new CheckBox();
            lblPhoto = new Label();
            pictureBoxPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            btnSubmit = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            bottomPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            tableLayoutPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTeacherId
            // 
            lblTeacherId.Location = new Point(3, 0);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(54, 20);
            lblTeacherId.TabIndex = 0;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(63, 3);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(100, 23);
            txtTeacherId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(3, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(54, 20);
            lblFirstName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(63, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(3, 40);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(54, 20);
            lblLastName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(63, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(3, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(54, 20);
            lblFullName.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(63, 63);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(3, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 20);
            lblEmail.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblDiscipline
            // 
            lblDiscipline.Location = new Point(3, 100);
            lblDiscipline.Name = "lblDiscipline";
            lblDiscipline.Size = new Size(54, 20);
            lblDiscipline.TabIndex = 10;
            // 
            // txtDiscipline
            // 
            txtDiscipline.Location = new Point(63, 103);
            txtDiscipline.Name = "txtDiscipline";
            txtDiscipline.Size = new Size(100, 23);
            txtDiscipline.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(3, 120);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 20);
            lblGender.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(63, 123);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 13;
            // 
            // chkIsAdministrator
            // 
            chkIsAdministrator.Location = new Point(63, 143);
            chkIsAdministrator.Name = "chkIsAdministrator";
            chkIsAdministrator.Size = new Size(104, 14);
            chkIsAdministrator.TabIndex = 14;
            // 
            // lblPhoto
            // 
            lblPhoto.Location = new Point(3, 160);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(54, 20);
            lblPhoto.TabIndex = 15;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(63, 163);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(100, 14);
            pictureBoxPhoto.TabIndex = 16;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(63, 183);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(75, 14);
            btnUploadPhoto.TabIndex = 17;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(3, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.Controls.Add(lblTeacherId, 0, 0);
            tableLayoutPanel.Controls.Add(txtTeacherId, 1, 0);
            tableLayoutPanel.Controls.Add(lblFirstName, 0, 1);
            tableLayoutPanel.Controls.Add(txtFirstName, 1, 1);
            tableLayoutPanel.Controls.Add(lblLastName, 0, 2);
            tableLayoutPanel.Controls.Add(txtLastName, 1, 2);
            tableLayoutPanel.Controls.Add(lblFullName, 0, 3);
            tableLayoutPanel.Controls.Add(txtFullName, 1, 3);
            tableLayoutPanel.Controls.Add(lblEmail, 0, 4);
            tableLayoutPanel.Controls.Add(txtEmail, 1, 4);
            tableLayoutPanel.Controls.Add(lblDiscipline, 0, 5);
            tableLayoutPanel.Controls.Add(txtDiscipline, 1, 5);
            tableLayoutPanel.Controls.Add(lblGender, 0, 6);
            tableLayoutPanel.Controls.Add(cmbGender, 1, 6);
            tableLayoutPanel.Controls.Add(chkIsAdministrator, 1, 7);
            tableLayoutPanel.Controls.Add(lblPhoto, 0, 8);
            tableLayoutPanel.Controls.Add(pictureBoxPhoto, 1, 8);
            tableLayoutPanel.Controls.Add(btnUploadPhoto, 1, 9);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(200, 100);
            tableLayoutPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(btnSubmit);
            bottomPanel.Location = new Point(0, 0);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(200, 100);
            bottomPanel.TabIndex = 1;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Controls.Add(bottomPanel);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTeacherId;
        private TextBox txtTeacherId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDiscipline;
        private TextBox txtDiscipline;
        private Label lblGender;
        private ComboBox cmbGender;
        private CheckBox chkIsAdministrator;
        private Label lblPhoto;
        private PictureBox pictureBoxPhoto;
        private Button btnUploadPhoto;
        private Button btnSubmit;
        private TableLayoutPanel tableLayoutPanel;
        private FlowLayoutPanel bottomPanel;
    }
}