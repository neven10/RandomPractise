namespace DapperCRUD
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_ime = new MetroFramework.Controls.MetroTextBox();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_prezime = new MetroFramework.Controls.MetroTextBox();
            this.txt_radnik_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_maticni = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.combo_sektor = new MetroFramework.Controls.MetroComboBox();
            this.tblsektorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_sektor = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_delete_radnik = new MetroFramework.Controls.MetroTile();
            this.btn_update_radnik = new MetroFramework.Controls.MetroTile();
            this.btn_insert_radnik = new MetroFramework.Controls.MetroTile();
            this.grid_radnik = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maticniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsektorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_radnik)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 312);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.grid_sektor);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.btn_delete_radnik);
            this.tabPage1.Controls.Add(this.btn_update_radnik);
            this.tabPage1.Controls.Add(this.btn_insert_radnik);
            this.tabPage1.Controls.Add(this.grid_radnik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Radnik";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txt_ime);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txt_prezime);
            this.panel1.Controls.Add(this.txt_radnik_id);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txt_maticni);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.combo_sektor);
            this.panel1.Location = new System.Drawing.Point(31, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 186);
            this.panel1.TabIndex = 24;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(38, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ime:";
            // 
            // txt_ime
            // 
            // 
            // 
            // 
            this.txt_ime.CustomButton.Image = null;
            this.txt_ime.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_ime.CustomButton.Name = "";
            this.txt_ime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ime.CustomButton.TabIndex = 1;
            this.txt_ime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ime.CustomButton.UseSelectable = true;
            this.txt_ime.CustomButton.Visible = false;
            this.txt_ime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "ime", true));
            this.txt_ime.Lines = new string[0];
            this.txt_ime.Location = new System.Drawing.Point(114, 19);
            this.txt_ime.MaxLength = 32767;
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.PasswordChar = '\0';
            this.txt_ime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ime.SelectedText = "";
            this.txt_ime.SelectionLength = 0;
            this.txt_ime.SelectionStart = 0;
            this.txt_ime.ShortcutsEnabled = true;
            this.txt_ime.Size = new System.Drawing.Size(121, 23);
            this.txt_ime.TabIndex = 12;
            this.txt_ime.UseSelectable = true;
            this.txt_ime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataSource = typeof(DapperCRUD.radnik);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(17, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 25);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Sektor:";
            // 
            // txt_prezime
            // 
            // 
            // 
            // 
            this.txt_prezime.CustomButton.Image = null;
            this.txt_prezime.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_prezime.CustomButton.Name = "";
            this.txt_prezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_prezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_prezime.CustomButton.TabIndex = 1;
            this.txt_prezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_prezime.CustomButton.UseSelectable = true;
            this.txt_prezime.CustomButton.Visible = false;
            this.txt_prezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "prezime", true));
            this.txt_prezime.Lines = new string[0];
            this.txt_prezime.Location = new System.Drawing.Point(114, 60);
            this.txt_prezime.MaxLength = 32767;
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.PasswordChar = '\0';
            this.txt_prezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_prezime.SelectedText = "";
            this.txt_prezime.SelectionLength = 0;
            this.txt_prezime.SelectionStart = 0;
            this.txt_prezime.ShortcutsEnabled = true;
            this.txt_prezime.Size = new System.Drawing.Size(121, 23);
            this.txt_prezime.TabIndex = 13;
            this.txt_prezime.UseSelectable = true;
            this.txt_prezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_prezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_radnik_id
            // 
            // 
            // 
            // 
            this.txt_radnik_id.CustomButton.Image = null;
            this.txt_radnik_id.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txt_radnik_id.CustomButton.Name = "";
            this.txt_radnik_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_radnik_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_radnik_id.CustomButton.TabIndex = 1;
            this.txt_radnik_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_radnik_id.CustomButton.UseSelectable = true;
            this.txt_radnik_id.CustomButton.Visible = false;
            this.txt_radnik_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "id", true));
            this.txt_radnik_id.Enabled = false;
            this.txt_radnik_id.Lines = new string[0];
            this.txt_radnik_id.Location = new System.Drawing.Point(241, 19);
            this.txt_radnik_id.MaxLength = 32767;
            this.txt_radnik_id.Name = "txt_radnik_id";
            this.txt_radnik_id.PasswordChar = '\0';
            this.txt_radnik_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_radnik_id.SelectedText = "";
            this.txt_radnik_id.SelectionLength = 0;
            this.txt_radnik_id.SelectionStart = 0;
            this.txt_radnik_id.ShortcutsEnabled = true;
            this.txt_radnik_id.Size = new System.Drawing.Size(33, 23);
            this.txt_radnik_id.TabIndex = 20;
            this.txt_radnik_id.UseSelectable = true;
            this.txt_radnik_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_radnik_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(11, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Maticni:";
            // 
            // txt_maticni
            // 
            // 
            // 
            // 
            this.txt_maticni.CustomButton.Image = null;
            this.txt_maticni.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_maticni.CustomButton.Name = "";
            this.txt_maticni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_maticni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_maticni.CustomButton.TabIndex = 1;
            this.txt_maticni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_maticni.CustomButton.UseSelectable = true;
            this.txt_maticni.CustomButton.Visible = false;
            this.txt_maticni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "maticni", true));
            this.txt_maticni.Lines = new string[0];
            this.txt_maticni.Location = new System.Drawing.Point(114, 101);
            this.txt_maticni.MaxLength = 32767;
            this.txt_maticni.Name = "txt_maticni";
            this.txt_maticni.PasswordChar = '\0';
            this.txt_maticni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_maticni.SelectedText = "";
            this.txt_maticni.SelectionLength = 0;
            this.txt_maticni.SelectionStart = 0;
            this.txt_maticni.ShortcutsEnabled = true;
            this.txt_maticni.Size = new System.Drawing.Size(121, 23);
            this.txt_maticni.TabIndex = 14;
            this.txt_maticni.UseSelectable = true;
            this.txt_maticni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_maticni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Prezime:";
            // 
            // combo_sektor
            // 
            this.combo_sektor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.radnikBindingSource, "sektorid", true));
            this.combo_sektor.DataSource = this.tblsektorBindingSource;
            this.combo_sektor.DisplayMember = "sektor";
            this.combo_sektor.FormattingEnabled = true;
            this.combo_sektor.ItemHeight = 23;
            this.combo_sektor.Location = new System.Drawing.Point(114, 142);
            this.combo_sektor.Name = "combo_sektor";
            this.combo_sektor.Size = new System.Drawing.Size(121, 29);
            this.combo_sektor.TabIndex = 15;
            this.combo_sektor.UseSelectable = true;
            this.combo_sektor.ValueMember = "id";
            this.combo_sektor.Click += new System.EventHandler(this.combo_sektor_Click);
            // 
            // tblsektorBindingSource
            // 
            this.tblsektorBindingSource.DataSource = typeof(DapperCRUD.tbl_sektor);
            // 
            // grid_sektor
            // 
            this.grid_sektor.AllowUserToResizeRows = false;
            this.grid_sektor.AutoGenerateColumns = false;
            this.grid_sektor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_sektor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_sektor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_sektor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_sektor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_sektor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sektor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.sektorDataGridViewTextBoxColumn});
            this.grid_sektor.DataSource = this.tblsektorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_sektor.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_sektor.EnableHeadersVisualStyles = false;
            this.grid_sektor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_sektor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_sektor.Location = new System.Drawing.Point(662, 180);
            this.grid_sektor.Name = "grid_sektor";
            this.grid_sektor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_sektor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_sektor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_sektor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sektor.Size = new System.Drawing.Size(297, 81);
            this.grid_sektor.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // sektorDataGridViewTextBoxColumn
            // 
            this.sektorDataGridViewTextBoxColumn.DataPropertyName = "sektor";
            this.sektorDataGridViewTextBoxColumn.HeaderText = "sektor";
            this.sektorDataGridViewTextBoxColumn.Name = "sektorDataGridViewTextBoxColumn";
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(389, 157);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 43);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_save.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(463, 218);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 43);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete_radnik
            // 
            this.btn_delete_radnik.ActiveControl = null;
            this.btn_delete_radnik.Location = new System.Drawing.Point(319, 218);
            this.btn_delete_radnik.Name = "btn_delete_radnik";
            this.btn_delete_radnik.Size = new System.Drawing.Size(112, 43);
            this.btn_delete_radnik.TabIndex = 19;
            this.btn_delete_radnik.Text = "Delete";
            this.btn_delete_radnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete_radnik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_delete_radnik.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_delete_radnik.UseSelectable = true;
            this.btn_delete_radnik.Click += new System.EventHandler(this.btn_delete_radnik_Click);
            // 
            // btn_update_radnik
            // 
            this.btn_update_radnik.ActiveControl = null;
            this.btn_update_radnik.Location = new System.Drawing.Point(175, 218);
            this.btn_update_radnik.Name = "btn_update_radnik";
            this.btn_update_radnik.Size = new System.Drawing.Size(112, 43);
            this.btn_update_radnik.TabIndex = 18;
            this.btn_update_radnik.Text = "Edit";
            this.btn_update_radnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_radnik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_update_radnik.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_update_radnik.UseSelectable = true;
            this.btn_update_radnik.Click += new System.EventHandler(this.btn_update_radnik_Click);
            // 
            // btn_insert_radnik
            // 
            this.btn_insert_radnik.ActiveControl = null;
            this.btn_insert_radnik.Location = new System.Drawing.Point(31, 218);
            this.btn_insert_radnik.Name = "btn_insert_radnik";
            this.btn_insert_radnik.Size = new System.Drawing.Size(112, 43);
            this.btn_insert_radnik.TabIndex = 17;
            this.btn_insert_radnik.Text = "New";
            this.btn_insert_radnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert_radnik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_insert_radnik.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_insert_radnik.UseSelectable = true;
            this.btn_insert_radnik.Click += new System.EventHandler(this.btn_insert_radnik_Click);
            // 
            // grid_radnik
            // 
            this.grid_radnik.AllowUserToAddRows = false;
            this.grid_radnik.AllowUserToDeleteRows = false;
            this.grid_radnik.AllowUserToResizeRows = false;
            this.grid_radnik.AutoGenerateColumns = false;
            this.grid_radnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_radnik.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_radnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_radnik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_radnik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_radnik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_radnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_radnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.maticniDataGridViewTextBoxColumn,
            this.sektoridDataGridViewTextBoxColumn});
            this.grid_radnik.DataSource = this.radnikBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_radnik.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_radnik.EnableHeadersVisualStyles = false;
            this.grid_radnik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_radnik.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_radnik.Location = new System.Drawing.Point(545, 15);
            this.grid_radnik.Name = "grid_radnik";
            this.grid_radnik.ReadOnly = true;
            this.grid_radnik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_radnik.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_radnik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_radnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_radnik.Size = new System.Drawing.Size(414, 152);
            this.grid_radnik.TabIndex = 16;
            this.grid_radnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_radnik_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maticniDataGridViewTextBoxColumn
            // 
            this.maticniDataGridViewTextBoxColumn.DataPropertyName = "maticni";
            this.maticniDataGridViewTextBoxColumn.HeaderText = "maticni";
            this.maticniDataGridViewTextBoxColumn.Name = "maticniDataGridViewTextBoxColumn";
            this.maticniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sektoridDataGridViewTextBoxColumn
            // 
            this.sektoridDataGridViewTextBoxColumn.DataPropertyName = "sektorid";
            this.sektoridDataGridViewTextBoxColumn.HeaderText = "sektorid";
            this.sektoridDataGridViewTextBoxColumn.Name = "sektoridDataGridViewTextBoxColumn";
            this.sektoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel5);
            this.tabPage2.Controls.Add(this.metroLabel6);
            this.tabPage2.Controls.Add(this.metroTextBox1);
            this.tabPage2.Controls.Add(this.metroTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sektor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(71, 42);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 25);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Rbr:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(48, 85);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 25);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Sektor:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(142, 85);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(142, 44);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox2.TabIndex = 16;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 426);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DapperCRUD ADO.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsektorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_radnik)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroGrid grid_radnik;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox combo_sektor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_maticni;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_prezime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_ime;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTile btn_delete_radnik;
        private MetroFramework.Controls.MetroTile btn_update_radnik;
        private MetroFramework.Controls.MetroTile btn_insert_radnik;
        private MetroFramework.Controls.MetroTextBox txt_radnik_id;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroGrid grid_sektor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblsektorBindingSource;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maticniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}

