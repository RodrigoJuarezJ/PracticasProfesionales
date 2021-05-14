
namespace PracticasProfesionales
{
    partial class FrmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtCellPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblCellPhone = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblPhoneNumber = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(5, 72);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidth = 51;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.RowTemplate.Height = 24;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(275, 221);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(PracticasProfesionales.Entidades.Student);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnSearch);
            this.pnlDatos.Controls.Add(this.txtCellPhone);
            this.pnlDatos.Controls.Add(this.lblCellPhone);
            this.pnlDatos.Controls.Add(this.txtPhoneNumber);
            this.pnlDatos.Controls.Add(this.lblPhoneNumber);
            this.pnlDatos.Controls.Add(this.txtLastName);
            this.pnlDatos.Controls.Add(this.lblLastName);
            this.pnlDatos.Controls.Add(this.txtFirstName);
            this.pnlDatos.Controls.Add(this.lblFirstName);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.pctPhoto);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(299, 72);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(544, 191);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCellPhone
            // 
            // 
            // 
            // 
            this.txtCellPhone.CustomButton.Image = null;
            this.txtCellPhone.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtCellPhone.CustomButton.Name = "";
            this.txtCellPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellPhone.CustomButton.TabIndex = 1;
            this.txtCellPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellPhone.CustomButton.UseSelectable = true;
            this.txtCellPhone.CustomButton.Visible = false;
            this.txtCellPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "CellPhone", true));
            this.txtCellPhone.Lines = new string[0];
            this.txtCellPhone.Location = new System.Drawing.Point(263, 127);
            this.txtCellPhone.MaxLength = 32767;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.PasswordChar = '\0';
            this.txtCellPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellPhone.SelectedText = "";
            this.txtCellPhone.SelectionLength = 0;
            this.txtCellPhone.SelectionStart = 0;
            this.txtCellPhone.ShortcutsEnabled = true;
            this.txtCellPhone.Size = new System.Drawing.Size(278, 23);
            this.txtCellPhone.TabIndex = 12;
            this.txtCellPhone.UseSelectable = true;
            this.txtCellPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(150, 127);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(72, 20);
            this.lblCellPhone.TabIndex = 11;
            this.lblCellPhone.Text = "CellPhone";
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(263, 98);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(278, 23);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(150, 98);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(105, 20);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(263, 69);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(278, 23);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(150, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(263, 40);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(278, 23);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(150, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 20);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(263, 11);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(278, 23);
            this.txtId.TabIndex = 4;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(150, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(0, 0);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(144, 119);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPhoto.TabIndex = 2;
            this.pctPhoto.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(625, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(544, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(463, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(381, 270);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 395);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtCellPhone;
        private MetroFramework.Controls.MetroLabel lblCellPhone;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroLabel lblPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
    }
}