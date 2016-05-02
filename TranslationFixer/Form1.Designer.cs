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
            this.buttonLoadSaveName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReplace
            // 
            this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReplace.FlatAppearance.BorderSize = 0;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Calibri", 15F);
            this.buttonReplace.ForeColor = System.Drawing.Color.White;
            this.buttonReplace.Location = new System.Drawing.Point(14, 170);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(256, 53);
            this.buttonReplace.TabIndex = 2;
            this.buttonReplace.Text = "Corriger";
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonLoadSaveName
            // 
            this.buttonLoadSaveName.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoadSaveName.FlatAppearance.BorderSize = 0;
            this.buttonLoadSaveName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSaveName.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.buttonLoadSaveName.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSaveName.Location = new System.Drawing.Point(14, 82);
            this.buttonLoadSaveName.Name = "buttonLoadSaveName";
            this.buttonLoadSaveName.Size = new System.Drawing.Size(256, 53);
            this.buttonLoadSaveName.TabIndex = 5;
            this.buttonLoadSaveName.Text = "Charger \"Nom_12345\"";
            this.buttonLoadSaveName.UseVisualStyleBackColor = false;
            this.buttonLoadSaveName.Click += new System.EventHandler(this.buttonLoadSaveName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(33, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.AutoSize = true;
            this.buttonMAJ.BackColor = System.Drawing.Color.Gray;
            this.buttonMAJ.FlatAppearance.BorderSize = 0;
            this.buttonMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAJ.Font = new System.Drawing.Font("Calibri", 11F);
            this.buttonMAJ.ForeColor = System.Drawing.Color.White;
            this.buttonMAJ.Location = new System.Drawing.Point(33, 235);
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
            this.checkBoxBackup.Font = new System.Drawing.Font("Calibri", 9F);
            this.checkBoxBackup.Location = new System.Drawing.Point(26, 141);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(233, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(82, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.Location = new System.Drawing.Point(58, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select your language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLoadSaveName);
            this.Controls.Add(this.buttonReplace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDVFR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonLoadSaveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

