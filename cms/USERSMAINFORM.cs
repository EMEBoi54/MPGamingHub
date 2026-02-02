using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finaluserandstaff
{
    public partial class UserManagementControl : UserControl
    {
        // UI Components
        private Panel panelHeader;
        private Panel panel2;
        private DataGridView datagrd;
        private Button btnManage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem uPDATEUSERToolStripMenuItem;
        private ToolStripMenuItem dELETEUSERToolStripMenuItem;
        private ToolStripMenuItem cHANGEPASSWORDToolStripMenuItem;
        private Label labelTitle;

        // DataGridView Columns
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn ROLE;
        private DataGridViewComboBoxColumn STATUS;

        public UserManagementControl()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Clean up components if needed
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrd = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrd)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Maroon;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.btnManage);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(120, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(464, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "USER AND STAFF MANAGEMENT | ADMIN SIDE";
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManage.BackColor = System.Drawing.Color.IndianRed;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(551, 20);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(180, 40);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "MANAGE USERS";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.datagrd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(800, 420);
            this.panel2.TabIndex = 1;
            // 
            // datagrd
            // 
            this.datagrd.AllowUserToAddRows = false;
            this.datagrd.AllowUserToDeleteRows = false;
            this.datagrd.AllowUserToResizeRows = false;
            this.datagrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.ROLE,
            this.STATUS});
            this.datagrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrd.GridColor = System.Drawing.Color.IndianRed;
            this.datagrd.Location = new System.Drawing.Point(20, 20);
            this.datagrd.MultiSelect = false;
            this.datagrd.Name = "datagrd";
            this.datagrd.RowHeadersWidth = 51;
            this.datagrd.RowTemplate.Height = 24;
            this.datagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrd.Size = new System.Drawing.Size(760, 380);
            this.datagrd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.uPDATEUSERToolStripMenuItem,
            this.dELETEUSERToolStripMenuItem,
            this.cHANGEPASSWORDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 24);
            this.toolStripMenuItem1.Text = "ADD NEW USER";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // uPDATEUSERToolStripMenuItem
            // 
            this.uPDATEUSERToolStripMenuItem.Name = "uPDATEUSERToolStripMenuItem";
            this.uPDATEUSERToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.uPDATEUSERToolStripMenuItem.Text = "UPDATE USER";
            this.uPDATEUSERToolStripMenuItem.Click += new System.EventHandler(this.uPDATEUSERToolStripMenuItem_Click);
            // 
            // dELETEUSERToolStripMenuItem
            // 
            this.dELETEUSERToolStripMenuItem.Name = "dELETEUSERToolStripMenuItem";
            this.dELETEUSERToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.dELETEUSERToolStripMenuItem.Text = "DELETE USER";
            this.dELETEUSERToolStripMenuItem.Click += new System.EventHandler(this.dELETEUSERToolStripMenuItem_Click);
            // 
            // cHANGEPASSWORDToolStripMenuItem
            // 
            this.cHANGEPASSWORDToolStripMenuItem.Name = "cHANGEPASSWORDToolStripMenuItem";
            this.cHANGEPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.cHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD";
            this.cHANGEPASSWORDToolStripMenuItem.Click += new System.EventHandler(this.cHANGEPASSWORDToolStripMenuItem_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "#ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "USERNAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // ROLE
            // 
            this.ROLE.HeaderText = "ROLE";
            this.ROLE.MinimumWidth = 6;
            this.ROLE.Name = "ROLE";
            this.ROLE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagementControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UserManagementControl_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrd)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.IContainer components;

        // Event Handlers
        private void Manage_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnManage, 0, btnManage.Height);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowAddUserForm();
        }

        private void uPDATEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagrd.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrd.SelectedRows[0];
                string selectedUser = selectedRow.Cells["NAME"].Value.ToString();
                string currentRole = selectedRow.Cells["ROLE"].Value.ToString();

                if (selectedUser == "admin01")
                {
                    MessageBox.Show("Admin user - role cannot be changed", "Admin User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create and show Update User Form directly
                ShowUpdateUserForm(selectedUser, currentRole, selectedRow.Index);
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dELETEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagrd.SelectedRows.Count > 0)
            {
                string selectedUser = datagrd.SelectedRows[0].Cells["NAME"].Value.ToString();

                if (selectedUser == "admin01")
                {
                    MessageBox.Show("Security Violation: You cannot delete your own administrative account!",
                        "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete user: {selectedUser}?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    datagrd.Rows.RemoveAt(datagrd.SelectedRows[0].Index);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagrd.SelectedRows.Count > 0)
            {
                string selectedUser = datagrd.SelectedRows[0].Cells["NAME"].Value.ToString();
                ShowChangePasswordForm(selectedUser);
            }
            else
            {
                MessageBox.Show("Please select a user to change password.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            datagrd.Rows.Clear();

            int rowIndex = datagrd.Rows.Add("00001", "admin01", "MANAGER", "ACTIVE");
            datagrd.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            datagrd.Rows[rowIndex].DefaultCellStyle.Font = new Font(datagrd.Font, FontStyle.Bold);

            for (int i = 2; i <= 20; i++)
            {
                string id = i.ToString("D5");
                string username = $"user{i:00}";
                string role = (i % 3 == 0) ? "STAFF" : "MANAGER";
                string status = (i % 4 == 0) ? "INACTIVE" : "ACTIVE";

                datagrd.Rows.Add(id, username, role, status);
            }
        }

        // ===== UPDATE USER FORM (Hardcoded) =====
        private void ShowUpdateUserForm(string username, string currentRole, int rowIndex)
        {
            Form updateForm = new Form();
            updateForm.Text = "Update User";
            updateForm.Size = new Size(450, 400);
            updateForm.StartPosition = FormStartPosition.CenterParent;
            updateForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            updateForm.MaximizeBox = false;
            updateForm.MinimizeBox = false;
            updateForm.BackColor = Color.MistyRose;

            // Maroon Header Panel
            Panel headerPanel = new Panel();
            headerPanel.BackColor = Color.Maroon;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 71;

            Label lblHeader = new Label();
            lblHeader.Text = "UPDATE FORM";
            lblHeader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(120, 20);

            headerPanel.Controls.Add(lblHeader);

            // Username Label
            Label lblUsername = new Label();
            lblUsername.Text = "ENTER NEW USERNAME";
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Maroon;
            lblUsername.Location = new Point(50, 90);
            lblUsername.AutoSize = true;

            // Username TextBox
            TextBox txtUsername = new TextBox();
            txtUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtUsername.Location = new Point(50, 120);
            txtUsername.Size = new Size(350, 38);
            txtUsername.Text = username;

            // Role ComboBox
            ComboBox cmbRole = new ComboBox();
            cmbRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            cmbRole.ForeColor = Color.Maroon;
            cmbRole.Location = new Point(50, 200);
            cmbRole.Size = new Size(350, 31);
            cmbRole.Items.AddRange(new object[] { "MANAGER", "STAFF" });
            cmbRole.Text = currentRole;

            // Buttons
            Button btnConfirm = new Button();
            btnConfirm.Text = "CONFIRM";
            btnConfirm.BackColor = Color.Green;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConfirm.Location = new Point(70, 260);
            btnConfirm.Size = new Size(140, 55);
            btnConfirm.Click += (s, eArgs) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the DataGridView
                datagrd.Rows[rowIndex].Cells["NAME"].Value = txtUsername.Text;
                datagrd.Rows[rowIndex].Cells["ROLE"].Value = cmbRole.Text;

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateForm.DialogResult = DialogResult.OK;
                updateForm.Close();
            };

            Button btnCancel = new Button();
            btnCancel.Text = "CANCEL";
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(230, 260);
            btnCancel.Size = new Size(140, 55);
            btnCancel.Click += (s, eArgs) =>
            {
                updateForm.DialogResult = DialogResult.Cancel;
                updateForm.Close();
            };

            // Add controls to form
            updateForm.Controls.AddRange(new Control[]
            {
                headerPanel, lblUsername, txtUsername, cmbRole, btnConfirm, btnCancel
            });

            updateForm.ShowDialog();
        }

        // ===== ADD USER FORM =====
        private void ShowAddUserForm()
        {
            Form addForm = new Form();
            addForm.Text = "Add New User";
            addForm.Size = new Size(400, 350);
            addForm.StartPosition = FormStartPosition.CenterParent;
            addForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.BackColor = Color.MistyRose;

            Label lblTitle = new Label();
            lblTitle.Text = "ADD NEW USER";
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(120, 20);
            lblTitle.AutoSize = true;

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(50, 70);
            lblUsername.AutoSize = true;

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(150, 67);
            txtUsername.Size = new Size(200, 27);

            Label lblRole = new Label();
            lblRole.Text = "Role:";
            lblRole.Location = new Point(50, 110);
            lblRole.AutoSize = true;

            ComboBox cmbRole = new ComboBox();
            cmbRole.Location = new Point(150, 107);
            cmbRole.Size = new Size(200, 28);
            cmbRole.Items.AddRange(new object[] { "MANAGER", "STAFF" });
            cmbRole.SelectedIndex = 0;

            Label lblStatus = new Label();
            lblStatus.Text = "Status:";
            lblStatus.Location = new Point(50, 150);
            lblStatus.AutoSize = true;

            ComboBox cmbStatus = new ComboBox();
            cmbStatus.Location = new Point(150, 147);
            cmbStatus.Size = new Size(200, 28);
            cmbStatus.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            cmbStatus.SelectedIndex = 0;

            Button btnAdd = new Button();
            btnAdd.Text = "ADD USER";
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(80, 200);
            btnAdd.Size = new Size(120, 40);
            btnAdd.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newId = datagrd.Rows.Count + 1;
                string id = newId.ToString("D5");

                datagrd.Rows.Add(id, txtUsername.Text, cmbRole.Text, cmbStatus.Text);

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addForm.Close();
            };

            Button btnCancel = new Button();
            btnCancel.Text = "CANCEL";
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(220, 200);
            btnCancel.Size = new Size(120, 40);
            btnCancel.Click += (s, e) => addForm.Close();

            addForm.Controls.AddRange(new Control[]
            {
                lblTitle, lblUsername, txtUsername, lblRole, cmbRole,
                lblStatus, cmbStatus, btnAdd, btnCancel
            });

            addForm.ShowDialog();
        }

        // ===== CHANGE PASSWORD FORM =====
        private void ShowChangePasswordForm(string username)
        {
            Form passForm = new Form();
            passForm.Text = "Change Password";
            passForm.Size = new Size(350, 250);
            passForm.StartPosition = FormStartPosition.CenterParent;
            passForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            passForm.MaximizeBox = false;
            passForm.MinimizeBox = false;

            Label lblUser = new Label();
            lblUser.Text = $"User: {username}";
            lblUser.Location = new Point(20, 20);
            lblUser.AutoSize = true;

            Label lblNewPass = new Label();
            lblNewPass.Text = "New Password:";
            lblNewPass.Location = new Point(20, 60);
            lblNewPass.AutoSize = true;

            TextBox txtNewPass = new TextBox();
            txtNewPass.Location = new Point(140, 57);
            txtNewPass.Size = new Size(160, 27);
            txtNewPass.PasswordChar = '*';

            Label lblConfirmPass = new Label();
            lblConfirmPass.Text = "Confirm Password:";
            lblConfirmPass.Location = new Point(20, 100);
            lblConfirmPass.AutoSize = true;

            TextBox txtConfirmPass = new TextBox();
            txtConfirmPass.Location = new Point(140, 97);
            txtConfirmPass.Size = new Size(160, 27);
            txtConfirmPass.PasswordChar = '*';

            Button btnChange = new Button();
            btnChange.Text = "CHANGE";
            btnChange.BackColor = Color.Green;
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(60, 150);
            btnChange.Size = new Size(100, 40);
            btnChange.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Password for {username} has been changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passForm.DialogResult = DialogResult.OK;
                passForm.Close();
            };

            Button btnCancel = new Button();
            btnCancel.Text = "CANCEL";
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(180, 150);
            btnCancel.Size = new Size(100, 40);
            btnCancel.Click += (s, e) =>
            {
                passForm.DialogResult = DialogResult.Cancel;
                passForm.Close();
            };

            passForm.Controls.AddRange(new Control[]
            {
                lblUser, lblNewPass, txtNewPass, lblConfirmPass, txtConfirmPass, btnChange, btnCancel
            });

            passForm.ShowDialog();
        }
    }
}