namespace EFModelFirst
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label maticniLabel;
            System.Windows.Forms.Label sektorIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.radnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.radnikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.maticniTextBox = new System.Windows.Forms.TextBox();
            this.sektorIdComboBox = new System.Windows.Forms.ComboBox();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            maticniLabel = new System.Windows.Forms.Label();
            sektorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingNavigator)).BeginInit();
            this.radnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radnikDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(80, 103);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(26, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(60, 133);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(46, 13);
            prezimeLabel.TabIndex = 5;
            prezimeLabel.Text = "prezime:";
            // 
            // maticniLabel
            // 
            maticniLabel.AutoSize = true;
            maticniLabel.Location = new System.Drawing.Point(63, 177);
            maticniLabel.Name = "maticniLabel";
            maticniLabel.Size = new System.Drawing.Size(43, 13);
            maticniLabel.TabIndex = 7;
            maticniLabel.Text = "maticni:";
            // 
            // sektorIdLabel
            // 
            sektorIdLabel.AutoSize = true;
            sektorIdLabel.Location = new System.Drawing.Point(55, 229);
            sektorIdLabel.Name = "sektorIdLabel";
            sektorIdLabel.Size = new System.Drawing.Size(51, 13);
            sektorIdLabel.TabIndex = 9;
            sektorIdLabel.Text = "sektor Id:";
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataSource = typeof(EFModelFirst.radnik);
            // 
            // radnikBindingNavigator
            // 
            this.radnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.radnikBindingNavigator.BindingSource = this.radnikBindingSource;
            this.radnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.radnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.radnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.radnikBindingNavigatorSaveItem});
            this.radnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.radnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.radnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.radnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.radnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.radnikBindingNavigator.Name = "radnikBindingNavigator";
            this.radnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.radnikBindingNavigator.Size = new System.Drawing.Size(970, 25);
            this.radnikBindingNavigator.TabIndex = 0;
            this.radnikBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // radnikBindingNavigatorSaveItem
            // 
            this.radnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.radnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("radnikBindingNavigatorSaveItem.Image")));
            this.radnikBindingNavigatorSaveItem.Name = "radnikBindingNavigatorSaveItem";
            this.radnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.radnikBindingNavigatorSaveItem.Text = "Save Data";
            this.radnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.radnikBindingNavigatorSaveItem_Click);
            // 
            // radnikDataGridView
            // 
            this.radnikDataGridView.AllowUserToAddRows = false;
            this.radnikDataGridView.AllowUserToDeleteRows = false;
            this.radnikDataGridView.AutoGenerateColumns = false;
            this.radnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.radnikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.radnikDataGridView.DataSource = this.radnikBindingSource;
            this.radnikDataGridView.Location = new System.Drawing.Point(401, 47);
            this.radnikDataGridView.Name = "radnikDataGridView";
            this.radnikDataGridView.ReadOnly = true;
            this.radnikDataGridView.Size = new System.Drawing.Size(547, 220);
            this.radnikDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "maticni";
            this.dataGridViewTextBoxColumn4.HeaderText = "maticni";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sektorId";
            this.dataGridViewTextBoxColumn5.HeaderText = "sektorId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sektor";
            this.dataGridViewTextBoxColumn6.HeaderText = "sektor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // sektorBindingSource
            // 
            this.sektorBindingSource.DataSource = typeof(EFModelFirst.sektor);
            // 
            // sektorDataGridView
            // 
            this.sektorDataGridView.AutoGenerateColumns = false;
            this.sektorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sektorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.sektorDataGridView.DataSource = this.sektorBindingSource;
            this.sektorDataGridView.Location = new System.Drawing.Point(697, 285);
            this.sektorDataGridView.Name = "sektorDataGridView";
            this.sektorDataGridView.Size = new System.Drawing.Size(251, 156);
            this.sektorDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn8.HeaderText = "naziv";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "radniks";
            this.dataGridViewTextBoxColumn9.HeaderText = "radniks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(124, 100);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(121, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(124, 130);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.prezimeTextBox.TabIndex = 6;
            // 
            // maticniTextBox
            // 
            this.maticniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radnikBindingSource, "maticni", true));
            this.maticniTextBox.Location = new System.Drawing.Point(124, 174);
            this.maticniTextBox.Name = "maticniTextBox";
            this.maticniTextBox.Size = new System.Drawing.Size(121, 20);
            this.maticniTextBox.TabIndex = 8;
            // 
            // sektorIdComboBox
            // 
            this.sektorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.radnikBindingSource, "sektorId", true));
            this.sektorIdComboBox.DataSource = this.sektorBindingSource;
            this.sektorIdComboBox.DisplayMember = "naziv";
            this.sektorIdComboBox.FormattingEnabled = true;
            this.sektorIdComboBox.Location = new System.Drawing.Point(124, 226);
            this.sektorIdComboBox.Name = "sektorIdComboBox";
            this.sektorIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.sektorIdComboBox.TabIndex = 10;
            this.sektorIdComboBox.ValueMember = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(sektorIdLabel);
            this.Controls.Add(this.sektorIdComboBox);
            this.Controls.Add(maticniLabel);
            this.Controls.Add(this.maticniTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.sektorDataGridView);
            this.Controls.Add(this.radnikDataGridView);
            this.Controls.Add(this.radnikBindingNavigator);
            this.Name = "Form1";
            this.Text = "Simple CRUD EF Model First";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingNavigator)).EndInit();
            this.radnikBindingNavigator.ResumeLayout(false);
            this.radnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radnikDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource radnikBindingSource;
        private System.Windows.Forms.BindingNavigator radnikBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton radnikBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView radnikDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource sektorBindingSource;
        private System.Windows.Forms.DataGridView sektorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox maticniTextBox;
        private System.Windows.Forms.ComboBox sektorIdComboBox;
    }
}

