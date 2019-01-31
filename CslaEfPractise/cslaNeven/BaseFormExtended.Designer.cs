namespace cslaNeven
{
    partial class BaseFormExtended
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormExtended));
            this.FondtoolStrip = new System.Windows.Forms.ToolStrip();
            this.btn_Dodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Izmjeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Snimi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Obrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Ponisti = new System.Windows.Forms.ToolStripButton();
            this.FondtoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FondtoolStrip
            // 
            this.FondtoolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.FondtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Dodaj,
            this.toolStripSeparator1,
            this.btn_Izmjeni,
            this.toolStripSeparator2,
            this.btn_Snimi,
            this.toolStripSeparator3,
            this.btn_Obrisi,
            this.toolStripSeparator4,
            this.btn_Ponisti});
            this.FondtoolStrip.Location = new System.Drawing.Point(20, 60);
            this.FondtoolStrip.Name = "FondtoolStrip";
            this.FondtoolStrip.Size = new System.Drawing.Size(483, 25);
            this.FondtoolStrip.TabIndex = 56;
            this.FondtoolStrip.Text = "toolStrip1";
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Image = global::cslaNeven.Properties.Resources.AddDoc;
            this.btn_Dodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(58, 22);
            this.btn_Dodaj.Text = "Dodaj";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Izmjeni
            // 
            this.btn_Izmjeni.Image = global::cslaNeven.Properties.Resources.editDoc;
            this.btn_Izmjeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Izmjeni.Name = "btn_Izmjeni";
            this.btn_Izmjeni.Size = new System.Drawing.Size(65, 22);
            this.btn_Izmjeni.Text = "Izmjeni";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Image = global::cslaNeven.Properties.Resources.savedoc;
            this.btn_Snimi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(57, 22);
            this.btn_Snimi.Text = "Snimi";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Obrisi
            // 
            this.btn_Obrisi.Image = global::cslaNeven.Properties.Resources.deletedoc;
            this.btn_Obrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Obrisi.Name = "btn_Obrisi";
            this.btn_Obrisi.Size = new System.Drawing.Size(58, 22);
            this.btn_Obrisi.Text = "Obriši";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Ponisti
            // 
            this.btn_Ponisti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Ponisti.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ponisti.Image")));
            this.btn_Ponisti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Ponisti.Name = "btn_Ponisti";
            this.btn_Ponisti.Size = new System.Drawing.Size(47, 22);
            this.btn_Ponisti.Text = "Poništi";
            // 
            // BaseFormExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.FondtoolStrip);
            this.Name = "BaseFormExtended";
            this.Text = "BaseFormExtended";
            this.Load += new System.EventHandler(this.BaseFormExtended_Load);
            this.FondtoolStrip.ResumeLayout(false);
            this.FondtoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip FondtoolStrip;
        private System.Windows.Forms.ToolStripButton btn_Dodaj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Izmjeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Snimi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Obrisi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Ponisti;
    }
}