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
            this.buttonLoadSaveGame = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadSaveName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChgts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadSaveGame
            // 
            this.buttonLoadSaveGame.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoadSaveGame.FlatAppearance.BorderSize = 0;
            this.buttonLoadSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSaveGame.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.buttonLoadSaveGame.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSaveGame.Location = new System.Drawing.Point(0, 126);
            this.buttonLoadSaveGame.Name = "buttonLoadSaveGame";
            this.buttonLoadSaveGame.Size = new System.Drawing.Size(287, 54);
            this.buttonLoadSaveGame.TabIndex = 0;
            this.buttonLoadSaveGame.Text = "Charger";
            this.buttonLoadSaveGame.UseVisualStyleBackColor = false;
            this.buttonLoadSaveGame.Click += new System.EventHandler(this.buttonLoadSaveGame_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReplace.FlatAppearance.BorderSize = 0;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.buttonReplace.ForeColor = System.Drawing.Color.White;
            this.buttonReplace.Location = new System.Drawing.Point(0, 273);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(287, 54);
            this.buttonReplace.TabIndex = 2;
            this.buttonReplace.Text = "Corriger";
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "2) Chargez le fichier \"SaveGameInfo\"";
            // 
            // buttonLoadSaveName
            // 
            this.buttonLoadSaveName.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoadSaveName.FlatAppearance.BorderSize = 0;
            this.buttonLoadSaveName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSaveName.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.buttonLoadSaveName.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSaveName.Location = new System.Drawing.Point(0, 37);
            this.buttonLoadSaveName.Name = "buttonLoadSaveName";
            this.buttonLoadSaveName.Size = new System.Drawing.Size(287, 54);
            this.buttonLoadSaveName.TabIndex = 5;
            this.buttonLoadSaveName.Text = "Charger";
            this.buttonLoadSaveName.UseVisualStyleBackColor = false;
            this.buttonLoadSaveName.Click += new System.EventHandler(this.buttonLoadSaveName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "1) Chargez le fichier \"VotreNom_xxxxx\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(95, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "SDV-FR Team\r\nv0.4 pre-release";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBackup.Location = new System.Drawing.Point(12, 196);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(269, 38);
            this.checkBoxBackup.TabIndex = 11;
            this.checkBoxBackup.Text = "Faire une backup avant le remplacement\r\ndans le dossier de la save (recommandé)";
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "3) Cliquez sur \"Corriger\"";
            // 
            // labelChgts
            // 
            this.labelChgts.AutoSize = true;
            this.labelChgts.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChgts.Location = new System.Drawing.Point(67, 340);
            this.labelChgts.Name = "labelChgts";
            this.labelChgts.Size = new System.Drawing.Size(0, 17);
            this.labelChgts.TabIndex = 13;
            this.labelChgts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 418);
            this.Controls.Add(this.labelChgts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadSaveName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonLoadSaveGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SDVFR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadSaveGame;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadSaveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChgts;
    }
}

