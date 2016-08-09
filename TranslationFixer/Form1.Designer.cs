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
        	this.buttonReplace = new System.Windows.Forms.Button();
        	this.buttonMAJ = new System.Windows.Forms.Button();
        	this.checkBoxBackup = new MaterialSkin.Controls.MaterialCheckBox();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.linkLabel1 = new System.Windows.Forms.LinkLabel();
        	this.labelCompWith = new System.Windows.Forms.Label();
        	this.comboBoxSave = new System.Windows.Forms.ComboBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// buttonReplace
        	// 
        	this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        	this.buttonReplace.FlatAppearance.BorderSize = 0;
        	this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonReplace.Font = new System.Drawing.Font("Calibri", 15F);
        	this.buttonReplace.ForeColor = System.Drawing.Color.White;
        	this.buttonReplace.Location = new System.Drawing.Point(14, 236);
        	this.buttonReplace.Name = "buttonReplace";
        	this.buttonReplace.Size = new System.Drawing.Size(256, 53);
        	this.buttonReplace.TabIndex = 2;
        	this.buttonReplace.Text = "Corriger";
        	this.buttonReplace.UseVisualStyleBackColor = false;
        	this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
        	// 
        	// buttonMAJ
        	// 
        	this.buttonMAJ.AutoSize = true;
        	this.buttonMAJ.BackColor = System.Drawing.Color.Gray;
        	this.buttonMAJ.FlatAppearance.BorderSize = 0;
        	this.buttonMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonMAJ.Font = new System.Drawing.Font("Calibri", 11F);
        	this.buttonMAJ.ForeColor = System.Drawing.Color.White;
        	this.buttonMAJ.Location = new System.Drawing.Point(33, 301);
        	this.buttonMAJ.Name = "buttonMAJ";
        	this.buttonMAJ.Size = new System.Drawing.Size(219, 33);
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
        	this.checkBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
        	this.checkBoxBackup.Location = new System.Drawing.Point(9, 203);
        	this.checkBoxBackup.Margin = new System.Windows.Forms.Padding(0);
        	this.checkBoxBackup.MouseLocation = new System.Drawing.Point(0, 0);
        	this.checkBoxBackup.MouseState = MaterialSkin.MouseState.HOVER;
        	this.checkBoxBackup.Name = "checkBoxBackup";
        	this.checkBoxBackup.Ripple = true;
        	this.checkBoxBackup.Size = new System.Drawing.Size(290, 30);
        	this.checkBoxBackup.TabIndex = 11;
        	this.checkBoxBackup.Text = "Backup dans le dossier de la save";
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
        	this.comboBox1.Location = new System.Drawing.Point(94, 107);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(88, 23);
        	this.comboBox1.TabIndex = 17;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
        	this.label1.Location = new System.Drawing.Point(48, 79);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(189, 25);
        	this.label1.TabIndex = 18;
        	this.label1.Text = "Select your language";
        	// 
        	// linkLabel1
        	// 
        	this.linkLabel1.AutoSize = true;
        	this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9F);
        	this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        	this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        	this.linkLabel1.Location = new System.Drawing.Point(6, 341);
        	this.linkLabel1.Name = "linkLabel1";
        	this.linkLabel1.Size = new System.Drawing.Size(267, 18);
        	this.linkLabel1.TabIndex = 19;
        	this.linkLabel1.TabStop = true;
        	this.linkLabel1.Text = "Created by the SDV Translation Community";
        	this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        	// 
        	// labelCompWith
        	// 
        	this.labelCompWith.AutoSize = true;
        	this.labelCompWith.Font = new System.Drawing.Font("Calibri", 9F);
        	this.labelCompWith.Location = new System.Drawing.Point(191, 43);
        	this.labelCompWith.Name = "labelCompWith";
        	this.labelCompWith.Size = new System.Drawing.Size(0, 18);
        	this.labelCompWith.TabIndex = 20;
        	// 
        	// comboBoxSave
        	// 
        	this.comboBoxSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxSave.FormattingEnabled = true;
        	this.comboBoxSave.Location = new System.Drawing.Point(82, 170);
        	this.comboBoxSave.Name = "comboBoxSave";
        	this.comboBoxSave.Size = new System.Drawing.Size(121, 24);
        	this.comboBoxSave.TabIndex = 21;
        	this.comboBoxSave.SelectedIndexChanged += new System.EventHandler(this.comboBoxSave_SelectedIndexChanged);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
        	this.label2.Location = new System.Drawing.Point(75, 142);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(147, 25);
        	this.label2.TabIndex = 22;
        	this.label2.Text = "Select your save";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(318, 400);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.comboBoxSave);
        	this.Controls.Add(this.labelCompWith);
        	this.Controls.Add(this.linkLabel1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.buttonMAJ);
        	this.Controls.Add(this.checkBoxBackup);
        	this.Controls.Add(this.buttonReplace);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Save Patch";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonMAJ;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxBackup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelCompWith;
        private System.Windows.Forms.ComboBox comboBoxSave;
        private System.Windows.Forms.Label label2;
    }
}

