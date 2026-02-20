namespace cms
{
    partial class GameRates
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dgvGameRates = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCourtType = new System.Windows.Forms.Label();
            this.txtCourtType = new System.Windows.Forms.TextBox();
            this.lblGameType = new System.Windows.Forms.Label();
            this.txtGameType = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mainTableLayout.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameRates)).BeginInit();
            this.editPanel.SuspendLayout();
            this.editTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.Color.White;
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayout.Controls.Add(this.dataPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.editPanel, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(1943, 1174);
            this.mainTableLayout.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.White;
            this.dataPanel.Controls.Add(this.dgvGameRates);
            this.dataPanel.Controls.Add(this.btnAddNew);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 4);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.dataPanel.Size = new System.Drawing.Size(1354, 1166);
            this.dataPanel.TabIndex = 0;
            // 
            // dgvGameRates
            // 
            this.dgvGameRates.AllowUserToAddRows = false;
            this.dgvGameRates.AllowUserToDeleteRows = false;
            this.dgvGameRates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGameRates.BackgroundColor = System.Drawing.Color.White;
            this.dgvGameRates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGameRates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGameRates.ColumnHeadersHeight = 50;
            this.dgvGameRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGameRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCourtType,
            this.colGameType,
            this.colRate,
            this.colEdit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGameRates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGameRates.EnableHeadersVisualStyles = false;
            this.dgvGameRates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGameRates.Location = new System.Drawing.Point(36, 99);
            this.dgvGameRates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGameRates.Name = "dgvGameRates";
            this.dgvGameRates.ReadOnly = true;
            this.dgvGameRates.RowHeadersVisible = false;
            this.dgvGameRates.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvGameRates.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGameRates.RowTemplate.Height = 45;
            this.dgvGameRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGameRates.Size = new System.Drawing.Size(1270, 1041);
            this.dgvGameRates.TabIndex = 1;
            this.dgvGameRates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGameRates_CellContentClick);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.FillWeight = 25F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 150;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCourtType
            // 
            this.colCourtType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCourtType.FillWeight = 25F;
            this.colCourtType.HeaderText = "Court Type";
            this.colCourtType.MinimumWidth = 150;
            this.colCourtType.Name = "colCourtType";
            this.colCourtType.ReadOnly = true;
            // 
            // colGameType
            // 
            this.colGameType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameType.FillWeight = 25F;
            this.colGameType.HeaderText = "Game Type";
            this.colGameType.MinimumWidth = 150;
            this.colGameType.Name = "colGameType";
            this.colGameType.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRate.FillWeight = 20F;
            this.colRate.HeaderText = "Rate per hour";
            this.colRate.MinimumWidth = 150;
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.FillWeight = 5F;
            this.colEdit.HeaderText = "";
            this.colEdit.MinimumWidth = 80;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 80;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(74)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(36, 25);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(202, 62);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "➕ Add New Rate";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.White;
            this.editPanel.Controls.Add(this.editTableLayout);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(1363, 4);
            this.editPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPanel.Name = "editPanel";
            this.editPanel.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.editPanel.Size = new System.Drawing.Size(577, 1166);
            this.editPanel.TabIndex = 1;
            this.editPanel.Visible = false;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editPanel_Paint);
            // 
            // editTableLayout
            // 
            this.editTableLayout.ColumnCount = 1;
            this.editTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editTableLayout.Controls.Add(this.lblEditTitle, 0, 0);
            this.editTableLayout.Controls.Add(this.lblName, 0, 1);
            this.editTableLayout.Controls.Add(this.txtName, 0, 2);
            this.editTableLayout.Controls.Add(this.lblCourtType, 0, 3);
            this.editTableLayout.Controls.Add(this.txtCourtType, 0, 4);
            this.editTableLayout.Controls.Add(this.lblGameType, 0, 5);
            this.editTableLayout.Controls.Add(this.txtGameType, 0, 6);
            this.editTableLayout.Controls.Add(this.lblRate, 0, 7);
            this.editTableLayout.Controls.Add(this.txtRate, 0, 8);
            this.editTableLayout.Controls.Add(this.btnSave, 0, 9);
            this.editTableLayout.Controls.Add(this.btnCancel, 0, 10);
            this.editTableLayout.Controls.Add(this.btnDelete, 0, 11);
            this.editTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTableLayout.Location = new System.Drawing.Point(22, 25);
            this.editTableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editTableLayout.Name = "editTableLayout";
            this.editTableLayout.RowCount = 13;
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.editTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editTableLayout.Size = new System.Drawing.Size(533, 1116);
            this.editTableLayout.TabIndex = 0;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.lblEditTitle.Location = new System.Drawing.Point(3, 0);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(527, 75);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "🎮 Edit Rate";
            this.lblEditTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(3, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(527, 38);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "📝 Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(3, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 34);
            this.txtName.TabIndex = 2;
            // 
            // lblCourtType
            // 
            this.lblCourtType.AutoSize = true;
            this.lblCourtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourtType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCourtType.Location = new System.Drawing.Point(3, 163);
            this.lblCourtType.Name = "lblCourtType";
            this.lblCourtType.Size = new System.Drawing.Size(527, 38);
            this.lblCourtType.TabIndex = 3;
            this.lblCourtType.Text = "🏟️ Court Type:";
            this.lblCourtType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourtType
            // 
            this.txtCourtType.BackColor = System.Drawing.Color.White;
            this.txtCourtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourtType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCourtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourtType.Location = new System.Drawing.Point(3, 205);
            this.txtCourtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourtType.Name = "txtCourtType";
            this.txtCourtType.Size = new System.Drawing.Size(527, 34);
            this.txtCourtType.TabIndex = 4;
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGameType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGameType.Location = new System.Drawing.Point(3, 251);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(527, 38);
            this.lblGameType.TabIndex = 5;
            this.lblGameType.Text = "🎯 Game Type:";
            this.lblGameType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGameType
            // 
            this.txtGameType.BackColor = System.Drawing.Color.White;
            this.txtGameType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGameType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGameType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGameType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGameType.Location = new System.Drawing.Point(3, 293);
            this.txtGameType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGameType.Name = "txtGameType";
            this.txtGameType.Size = new System.Drawing.Size(527, 34);
            this.txtGameType.TabIndex = 6;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRate.Location = new System.Drawing.Point(3, 339);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(527, 38);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "💰 Rate per hour:";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRate.Location = new System.Drawing.Point(3, 381);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(527, 34);
            this.txtRate.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(74)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 431);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(527, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "💾 Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(3, 493);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(527, 54);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 555);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(527, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "🗑️ Delete Rate";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GameRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainTableLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameRates";
            this.Size = new System.Drawing.Size(1943, 1174);
            this.mainTableLayout.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameRates)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editTableLayout.ResumeLayout(false);
            this.editTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dgvGameRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.TableLayoutPanel editTableLayout;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCourtType;
        private System.Windows.Forms.TextBox txtCourtType;
        private System.Windows.Forms.Label lblGameType;
        private System.Windows.Forms.TextBox txtGameType;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}