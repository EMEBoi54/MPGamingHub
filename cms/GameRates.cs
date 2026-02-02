using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cms
{
    public partial class GameRates : UserControl
    {
        private bool _isAddingNew = true;
        private int _currentRowIndex = -1;

        public GameRates()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Setup event handlers
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnCancel.Click += BtnCancel_Click;
            btnAddNew.Click += BtnAddNew_Click;

            dgvGameRates.CellContentClick += DgvGameRates_CellContentClick;

            // Add sample data
            AddSampleData();

            // Set initial state - edit panel HIDDEN by default
            SetEditPanelVisible(false);
        }

        private void AddSampleData()
        {
            // Clear existing data
            dgvGameRates.Rows.Clear();

            // Add sample data
            dgvGameRates.Rows.Add("Badminton Court 1", "Indoor", "Badminton", "500");
            dgvGameRates.Rows.Add("Tennis Court A", "Outdoor", "Tennis", "800");
            dgvGameRates.Rows.Add("Basketball Court", "Indoor", "Basketball", "700");
            dgvGameRates.Rows.Add("Volleyball Court", "Outdoor", "Volleyball", "600");
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowEditPanelForNewEntry();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (_isAddingNew)
            {
                // Add new rate
                dgvGameRates.Rows.Add(
                    txtName.Text.Trim(),
                    txtCourtType.Text.Trim(),
                    txtGameType.Text.Trim(),
                    txtRate.Text.Trim()
                );

                MessageBox.Show("Game rate added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_currentRowIndex >= 0)
            {
                // Update existing rate using column names
                dgvGameRates.Rows[_currentRowIndex].Cells["colName"].Value = txtName.Text.Trim();
                dgvGameRates.Rows[_currentRowIndex].Cells["colCourtType"].Value = txtCourtType.Text.Trim();
                dgvGameRates.Rows[_currentRowIndex].Cells["colGameType"].Value = txtGameType.Text.Trim();
                dgvGameRates.Rows[_currentRowIndex].Cells["colRate"].Value = txtRate.Text.Trim();

                MessageBox.Show("Game rate updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SetEditPanelVisible(false);
            ClearForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!_isAddingNew && _currentRowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this game rate?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvGameRates.Rows.RemoveAt(_currentRowIndex);
                    MessageBox.Show("Game rate deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SetEditPanelVisible(false);
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Please select a game rate to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetEditPanelVisible(false);
            ClearForm();
        }

        private void DgvGameRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle the edit button column click
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGameRates.Columns["colEdit"].Index)
            {
                ShowEditPanelForEdit(e.RowIndex);
            }
        }

        private void ShowEditPanelForNewEntry()
        {
            _isAddingNew = true;
            _currentRowIndex = -1;
            ClearForm();

            lblEditTitle.Text = "➕ Add New Rate";
            btnSave.Text = "➕ Add Rate";
            btnDelete.Visible = false;

            SetEditPanelVisible(true);
        }

        private void ShowEditPanelForEdit(int rowIndex)
        {
            _isAddingNew = false;
            _currentRowIndex = rowIndex;

            if (rowIndex >= 0 && rowIndex < dgvGameRates.Rows.Count)
            {
                DataGridViewRow row = dgvGameRates.Rows[rowIndex];

                // Use column names instead of indices to avoid errors
                string name = row.Cells["colName"].Value?.ToString();
                string courtType = row.Cells["colCourtType"].Value?.ToString();
                string gameType = row.Cells["colGameType"].Value?.ToString();
                string rate = row.Cells["colRate"].Value?.ToString();

                txtName.Text = name;
                txtCourtType.Text = courtType;
                txtGameType.Text = gameType;
                txtRate.Text = rate;
            }

            lblEditTitle.Text = "✏️ Edit Rate";
            btnSave.Text = "💾 Save Changes";
            btnDelete.Visible = true;

            SetEditPanelVisible(true);
        }

        private void SetEditPanelVisible(bool isVisible)
        {
            // Show/hide the edit panel
            editPanel.Visible = isVisible;

            // Enable/disable buttons based on state
            btnAddNew.Enabled = !isVisible;
            dgvGameRates.Enabled = !isVisible;

            // Focus on first field when panel is shown
            if (isVisible)
            {
                txtName.Focus();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCourtType.Text))
            {
                MessageBox.Show("Please enter court type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourtType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGameType.Text))
            {
                MessageBox.Show("Please enter game type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGameType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show("Please enter rate.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                return false;
            }

            if (!decimal.TryParse(txtRate.Text, out decimal rate))
            {
                MessageBox.Show("Rate must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                txtRate.SelectAll();
                return false;
            }

            if (rate <= 0)
            {
                MessageBox.Show("Rate must be greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                txtRate.SelectAll();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            if (_isAddingNew)
            {
                txtName.Clear();
                txtCourtType.Clear();
                txtGameType.Clear();
                txtRate.Clear();
            }
            dgvGameRates.ClearSelection();
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            // This is the old event handler - keeping it to prevent errors
            // but the main logic is in BtnAddNew_Click
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // This is the old event handler - keeping it to prevent errors
            // but the main logic is in BtnDelete_Click
        }

        private void editPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}