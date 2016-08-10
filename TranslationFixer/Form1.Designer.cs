namespace TranslationFixer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.buttonReplace = new MaterialSkin.Controls.MaterialRaisedButton();
        	this.buttonMAJ = new System.Windows.Forms.Button();
        	this.checkBoxBackup = new MaterialSkin.Controls.MaterialCheckBox();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.linkLabel1 = new System.Windows.Forms.LinkLabel();
        	this.comboBoxSave = new System.Windows.Forms.ComboBox();
        	this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        	this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        	this.SuspendLayout();
        	// 
        	// buttonReplace
        	// 
        	this.buttonReplace.Depth = 0;
        	this.buttonReplace.Location = new System.Drawing.Point(36, 234);
        	this.buttonReplace.MouseState = MaterialSkin.MouseState.HOVER;
        	this.buttonReplace.Name = "buttonReplace";
        	this.buttonReplace.Primary = true;
        	this.buttonReplace.Size = new System.Drawing.Size(148, 36);
        	this.buttonReplace.TabIndex = 24;
        	this.buttonReplace.Text = "Corriger";
        	this.buttonReplace.UseVisualStyleBackColor = true;
        	this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
        	// 
        	// buttonMAJ
        	// 
        	this.buttonMAJ.AutoSize = true;
        	this.buttonMAJ.BackColor = System.Drawing.Color.Gray;
        	this.buttonMAJ.FlatAppearance.BorderSize = 0;
        	this.buttonMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonMAJ.Font = new System.Drawing.Font("Segoe UI", 11F);
        	this.buttonMAJ.ForeColor = System.Drawing.Color.White;
        	this.buttonMAJ.Location = new System.Drawing.Point(25, 286);
        	this.buttonMAJ.Margin = new System.Windows.Forms.Padding(2);
        	this.buttonMAJ.Name = "buttonMAJ";
        	this.buttonMAJ.Size = new System.Drawing.Size(164, 30);
        	this.buttonMAJ.TabIndex = 16;
        	this.buttonMAJ.Text = "Changelog";
        	this.buttonMAJ.UseVisualStyleBackColor = false;
        	this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
        	// 
        	// checkBoxBackup
        	// 
        	this.checkBoxBackup.AutoSize = true;
        	this.checkBoxBackup.BackColor = System.Drawing.Color.White;
        	this.checkBoxBackup.Checked = true;
        	this.checkBoxBackup.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.checkBoxBackup.Depth = 0;
        	this.checkBoxBackup.Font = new System.Drawing.Font("Roboto", 10F);
        	this.checkBoxBackup.Location = new System.Drawing.Point(67, 189);
        	this.checkBoxBackup.Margin = new System.Windows.Forms.Padding(0);
        	this.checkBoxBackup.MouseLocation = new System.Drawing.Point(0, 0);
        	this.checkBoxBackup.MouseState = MaterialSkin.MouseState.HOVER;
        	this.checkBoxBackup.Name = "checkBoxBackup";
        	this.checkBoxBackup.Ripple = true;
        	this.checkBoxBackup.Size = new System.Drawing.Size(76, 30);
        	this.checkBoxBackup.TabIndex = 11;
        	this.checkBoxBackup.Text = "Backup";
        	this.checkBoxBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.checkBoxBackup.UseVisualStyleBackColor = false;
        	this.checkBoxBackup.CheckedChanged += new System.EventHandler(this.checkBoxBackup_CheckedChanged);
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.Font = new System.Drawing.Font("Calibri", 7.8F);
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
			"Français",
			"Español"});
        	this.comboBox1.Location = new System.Drawing.Point(76, 94);
        	this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(67, 21);
        	this.comboBox1.TabIndex = 17;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        	// 
        	// linkLabel1
        	// 
        	this.linkLabel1.AutoSize = true;
        	this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9F);
        	this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        	this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        	this.linkLabel1.Location = new System.Drawing.Point(4, 329);
        	this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.linkLabel1.Name = "linkLabel1";
        	this.linkLabel1.Size = new System.Drawing.Size(217, 14);
        	this.linkLabel1.TabIndex = 19;
        	this.linkLabel1.TabStop = true;
        	this.linkLabel1.Text = "Created by the SDV Translation Community";
        	this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        	// 
        	// comboBoxSave
        	// 
        	this.comboBoxSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxSave.FormattingEnabled = true;
        	this.comboBoxSave.Location = new System.Drawing.Point(65, 154);
        	this.comboBoxSave.Margin = new System.Windows.Forms.Padding(2);
        	this.comboBoxSave.Name = "comboBoxSave";
        	this.comboBoxSave.Size = new System.Drawing.Size(92, 21);
        	this.comboBoxSave.TabIndex = 21;
        	this.comboBoxSave.SelectedIndexChanged += new System.EventHandler(this.comboBoxSave_SelectedIndexChanged);
        	// 
        	// materialLabel1
        	// 
        	this.materialLabel1.Depth = 0;
        	this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
        	this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        	this.materialLabel1.Location = new System.Drawing.Point(36, 69);
        	this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        	this.materialLabel1.Name = "materialLabel1";
        	this.materialLabel1.Size = new System.Drawing.Size(158, 23);
        	this.materialLabel1.TabIndex = 25;
        	this.materialLabel1.Text = "Select your language";
        	// 
        	// materialLabel2
        	// 
        	this.materialLabel2.Depth = 0;
        	this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
        	this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        	this.materialLabel2.Location = new System.Drawing.Point(47, 129);
        	this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        	this.materialLabel2.Name = "materialLabel2";
        	this.materialLabel2.Size = new System.Drawing.Size(123, 23);
        	this.materialLabel2.TabIndex = 26;
        	this.materialLabel2.Text = "Select your save";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(224, 363);
        	this.Controls.Add(this.materialLabel2);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.materialLabel1);
        	this.Controls.Add(this.comboBoxSave);
        	this.Controls.Add(this.linkLabel1);
        	this.Controls.Add(this.buttonMAJ);
        	this.Controls.Add(this.checkBoxBackup);
        	this.Controls.Add(this.buttonReplace);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Save Patch v0.15";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonReplace;
        private System.Windows.Forms.Button buttonMAJ;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxBackup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBoxSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

