namespace cslaNeven
{
    partial class FondUI
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
            this.txt_naziv_lijek = new MetroFramework.Controls.MetroTextBox();
            this.FondEditBS = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.txt_sifra_fond = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.FondInfoListBS = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Aktivan = new MetroFramework.Controls.MetroLabel();
            this.check_Aktivan = new System.Windows.Forms.CheckBox();
            this.FonderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grid_fond = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraFondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivFondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FondEditBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondInfoListBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FonderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_fond)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_naziv_lijek
            // 
            // 
            // 
            // 
            this.txt_naziv_lijek.CustomButton.Image = null;
            this.txt_naziv_lijek.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txt_naziv_lijek.CustomButton.Name = "";
            this.txt_naziv_lijek.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_naziv_lijek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_naziv_lijek.CustomButton.TabIndex = 1;
            this.txt_naziv_lijek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_naziv_lijek.CustomButton.UseSelectable = true;
            this.txt_naziv_lijek.CustomButton.Visible = false;
            this.txt_naziv_lijek.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FondEditBS, "nazivFond", true));
            this.txt_naziv_lijek.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_naziv_lijek.Lines = new string[0];
            this.txt_naziv_lijek.Location = new System.Drawing.Point(106, 195);
            this.txt_naziv_lijek.MaxLength = 32767;
            this.txt_naziv_lijek.Name = "txt_naziv_lijek";
            this.txt_naziv_lijek.PasswordChar = '\0';
            this.txt_naziv_lijek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_naziv_lijek.SelectedText = "";
            this.txt_naziv_lijek.SelectionLength = 0;
            this.txt_naziv_lijek.SelectionStart = 0;
            this.txt_naziv_lijek.ShortcutsEnabled = true;
            this.txt_naziv_lijek.Size = new System.Drawing.Size(265, 23);
            this.txt_naziv_lijek.TabIndex = 49;
            this.txt_naziv_lijek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_naziv_lijek.UseSelectable = true;
            this.txt_naziv_lijek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_naziv_lijek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FondEditBS
            // 
            this.FondEditBS.DataSource = typeof(BusinessLayer.FondEdit);
            // 
            // metroLabel43
            // 
            this.metroLabel43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel43.Location = new System.Drawing.Point(33, 188);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(49, 25);
            this.metroLabel43.TabIndex = 48;
            this.metroLabel43.Tag = "";
            this.metroLabel43.Text = "Lijek:";
            // 
            // txt_sifra_fond
            // 
            // 
            // 
            // 
            this.txt_sifra_fond.CustomButton.Image = null;
            this.txt_sifra_fond.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.txt_sifra_fond.CustomButton.Name = "";
            this.txt_sifra_fond.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_sifra_fond.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sifra_fond.CustomButton.TabIndex = 1;
            this.txt_sifra_fond.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sifra_fond.CustomButton.UseSelectable = true;
            this.txt_sifra_fond.CustomButton.Visible = false;
            this.txt_sifra_fond.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FondEditBS, "sifraFond", true));
            this.txt_sifra_fond.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_sifra_fond.Lines = new string[0];
            this.txt_sifra_fond.Location = new System.Drawing.Point(106, 151);
            this.txt_sifra_fond.MaxLength = 32767;
            this.txt_sifra_fond.Name = "txt_sifra_fond";
            this.txt_sifra_fond.PasswordChar = '\0';
            this.txt_sifra_fond.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sifra_fond.SelectedText = "";
            this.txt_sifra_fond.SelectionLength = 0;
            this.txt_sifra_fond.SelectionStart = 0;
            this.txt_sifra_fond.ShortcutsEnabled = true;
            this.txt_sifra_fond.Size = new System.Drawing.Size(78, 23);
            this.txt_sifra_fond.TabIndex = 47;
            this.txt_sifra_fond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sifra_fond.UseSelectable = true;
            this.txt_sifra_fond.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sifra_fond.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel51
            // 
            this.metroLabel51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel51.Location = new System.Drawing.Point(33, 148);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(49, 25);
            this.metroLabel51.TabIndex = 46;
            this.metroLabel51.Text = "Šifra:";
            // 
            // FondInfoListBS
            // 
            this.FondInfoListBS.DataSource = typeof(BusinessLayer.FondInfoList);
            // 
            // lbl_Aktivan
            // 
            this.lbl_Aktivan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Aktivan.AutoSize = true;
            this.lbl_Aktivan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Aktivan.Location = new System.Drawing.Point(33, 228);
            this.lbl_Aktivan.Name = "lbl_Aktivan";
            this.lbl_Aktivan.Size = new System.Drawing.Size(67, 25);
            this.lbl_Aktivan.TabIndex = 57;
            this.lbl_Aktivan.Text = "Aktivan";
            // 
            // check_Aktivan
            // 
            this.check_Aktivan.AutoSize = true;
            this.check_Aktivan.Checked = true;
            this.check_Aktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Aktivan.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.FondEditBS, "Aktivan", true));
            this.check_Aktivan.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.FondEditBS, "Aktivan", true));
            this.check_Aktivan.Location = new System.Drawing.Point(107, 239);
            this.check_Aktivan.Margin = new System.Windows.Forms.Padding(4);
            this.check_Aktivan.Name = "check_Aktivan";
            this.check_Aktivan.Size = new System.Drawing.Size(15, 14);
            this.check_Aktivan.TabIndex = 58;
            this.check_Aktivan.UseVisualStyleBackColor = true;
            // 
            // FonderrorProvider
            // 
            this.FonderrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FonderrorProvider.ContainerControl = this;
            this.FonderrorProvider.DataSource = this.FondEditBS;
            // 
            // grid_fond
            // 
            this.grid_fond.AllowUserToAddRows = false;
            this.grid_fond.AllowUserToDeleteRows = false;
            this.grid_fond.AllowUserToResizeRows = false;
            this.grid_fond.AutoGenerateColumns = false;
            this.grid_fond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_fond.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_fond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_fond.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_fond.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_fond.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_fond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_fond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sifraFondDataGridViewTextBoxColumn,
            this.nazivFondDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn});
            this.grid_fond.DataSource = this.FondInfoListBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_fond.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_fond.EnableHeadersVisualStyles = false;
            this.grid_fond.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_fond.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_fond.Location = new System.Drawing.Point(33, 289);
            this.grid_fond.Name = "grid_fond";
            this.grid_fond.ReadOnly = true;
            this.grid_fond.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_fond.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_fond.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_fond.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_fond.Size = new System.Drawing.Size(409, 150);
            this.grid_fond.TabIndex = 59;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifraFondDataGridViewTextBoxColumn
            // 
            this.sifraFondDataGridViewTextBoxColumn.DataPropertyName = "sifraFond";
            this.sifraFondDataGridViewTextBoxColumn.HeaderText = "sifraFond";
            this.sifraFondDataGridViewTextBoxColumn.Name = "sifraFondDataGridViewTextBoxColumn";
            this.sifraFondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivFondDataGridViewTextBoxColumn
            // 
            this.nazivFondDataGridViewTextBoxColumn.DataPropertyName = "nazivFond";
            this.nazivFondDataGridViewTextBoxColumn.HeaderText = "nazivFond";
            this.nazivFondDataGridViewTextBoxColumn.Name = "nazivFondDataGridViewTextBoxColumn";
            this.nazivFondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FondUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 462);
            this.Controls.Add(this.grid_fond);
            this.Controls.Add(this.check_Aktivan);
            this.Controls.Add(this.lbl_Aktivan);
            this.Controls.Add(this.txt_naziv_lijek);
            this.Controls.Add(this.metroLabel43);
            this.Controls.Add(this.txt_sifra_fond);
            this.Controls.Add(this.metroLabel51);
            this.Name = "FondUI";
            this.Text = "Lista Fonda";
            this.Load += new System.EventHandler(this.FondUI_Load);
            this.Controls.SetChildIndex(this.metroLabel51, 0);
            this.Controls.SetChildIndex(this.txt_sifra_fond, 0);
            this.Controls.SetChildIndex(this.metroLabel43, 0);
            this.Controls.SetChildIndex(this.txt_naziv_lijek, 0);
            this.Controls.SetChildIndex(this.lbl_Aktivan, 0);
            this.Controls.SetChildIndex(this.check_Aktivan, 0);
            this.Controls.SetChildIndex(this.grid_fond, 0);
            ((System.ComponentModel.ISupportInitialize)(this.FondEditBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondInfoListBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FonderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_fond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_naziv_lijek;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroTextBox txt_sifra_fond;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        private System.Windows.Forms.BindingSource FondInfoListBS;
        private System.Windows.Forms.BindingSource FondEditBS;
        private MetroFramework.Controls.MetroLabel lbl_Aktivan;
        private System.Windows.Forms.CheckBox check_Aktivan;
        private System.Windows.Forms.ErrorProvider FonderrorProvider;
        private MetroFramework.Controls.MetroGrid grid_fond;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraFondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivFondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
    }
}