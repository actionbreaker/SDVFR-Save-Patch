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
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.labelChgts = new System.Windows.Forms.Label();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReplace
            // 
            this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReplace.FlatAppearance.BorderSize = 0;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.buttonReplace.ForeColor = System.Drawing.Color.White;
            this.buttonReplace.Location = new System.Drawing.Point(0, 147);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(287, 54);
            this.buttonReplace.TabIndex = 2;
            this.buttonReplace.Text = "Français";
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
            this.buttonLoadSaveName.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadSaveName.Name = "buttonLoadSaveName";
            this.buttonLoadSaveName.Size = new System.Drawing.Size(287, 54);
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
            this.label3.Location = new System.Drawing.Point(39, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Créé avec amour par la team SDVFR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.BackColor = System.Drawing.Color.White;
            this.checkBoxBackup.Checked = true;
            this.checkBoxBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackup.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBackup.Location = new System.Drawing.Point(12, 65);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(269, 38);
            this.checkBoxBackup.TabIndex = 11;
            this.checkBoxBackup.Text = "Faire une backup avant le remplacement\r\ndans le dossier de la save (recommandé)";
            this.checkBoxBackup.UseVisualStyleBackColor = false;
            this.checkBoxBackup.CheckedChanged += new System.EventHandler(this.checkBoxBackup_CheckedChanged);
            // 
            // labelChgts
            // 
            this.labelChgts.AutoSize = true;
            this.labelChgts.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChgts.Location = new System.Drawing.Point(33, 238);
            this.labelChgts.Name = "labelChgts";
            this.labelChgts.Size = new System.Drawing.Size(0, 17);
            this.labelChgts.TabIndex = 13;
            this.labelChgts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.BackColor = System.Drawing.Color.Gray;
            this.buttonMAJ.FlatAppearance.BorderSize = 0;
            this.buttonMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAJ.Font = new System.Drawing.Font("Calibri", 11F);
            this.buttonMAJ.ForeColor = System.Drawing.Color.White;
            this.buttonMAJ.Location = new System.Drawing.Point(36, 254);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(219, 39);
            this.buttonMAJ.TabIndex = 16;
            this.buttonMAJ.Text = "Vérifier les mises à jour";
            this.buttonMAJ.UseVisualStyleBackColor = false;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.label1.Location = new System.Drawing.Point(75, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Traduire en : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel1.Location = new System.Drawing.Point(0, 315);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(287, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Changelog";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.labelChgts);
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
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.Label labelChgts;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

