using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TranslationFixer
{
    public partial class Form1 : Form
    {
        Fonctions mOperation;
        Form2 mForm2;

        XDocument docName;
        XDocument docGame;

        private string pathfileName;
        string pathDirectoryName;
        string name;
        string currentVersion = "v0.13.1";

        bool done;
        bool fileLoaded;
        bool hasUpdate = false;
        string last;

        public Form1()
        {
            InitializeComponent();

            done = false;
            fileLoaded = false;
            mOperation = new Fonctions();

            // Langue par défaut
            comboBox1.Text = "Français";

            // Corriger
            buttonReplace.Enabled = false;
            buttonReplace.BackColor = Color.White;
            buttonReplace.Text = "Save Patch " + currentVersion;

            // Recherche de MAJ
            buttonMAJ.Text = "Recherche...";
            CheckUpdate();

        }

        private void buttonLoadSaveName_Click(object sender, EventArgs e)   // Charger Nom_56557
        {
            // Sélection du fichier
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley\\Saves";
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathfileName = openFileDialog2.FileName;                    // Chemin + Nom fichier
                pathDirectoryName = Path.GetDirectoryName(pathfileName);    // Chemin
                name = Path.GetFileNameWithoutExtension(pathfileName);      // Nom fichier

                try
                {
                    // Chargement du fichier
                    // Erreur
                    if (name == "SaveGameInfo")
                    {
                        buttonLoadSaveName.BackColor = Color.Firebrick;
                        buttonLoadSaveName.Text = "Mauvais fichier";
                    }
                    // Bon fichier
                    else
                    {
                        // Chargement Nom_12345
                        fileLoaded = true;
                        docName = XDocument.Load(pathfileName);

                        // Chargement SaveGameInfo
                        docGame = XDocument.Load(pathDirectoryName + "\\SaveGameInfo");

                        buttonLoadSaveName.BackColor = Color.LimeGreen;
                        buttonLoadSaveName.Text = name.Trim(new Char[] { '_', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });

                        // Bouton "Corriger"
                        buttonReplace.Enabled = true;
                        buttonReplace.Font = new Font("Calibri Light", 15F);
                        buttonReplace.BackColor = SystemColors.Highlight;
                        buttonReplace.Text = Translate_Traduire();
                    }
                }
                catch
                {
                    buttonReplace.Enabled = false;
                    buttonReplace.BackColor = Color.White;
                    buttonLoadSaveName.Text = Translate_Erreur();
                }
            }
        }

        private async void buttonReplace_Click(object sender, EventArgs el)
        {
            if (done == false)
            {
                try
                {
                    // Bouton en cours
                    buttonReplace.Enabled = false;
                    buttonReplace.BackColor = Color.White;

                    // Backup
                    if (checkBoxBackup.Checked == true)
                    {
                        buttonReplace.Text = "Backup...";
                        File.Delete(pathDirectoryName + "\\" + name + "BACKUP");
                        File.Delete(pathDirectoryName + "\\" + "SaveGameInfoBACKUP");
                        File.Copy(pathfileName, pathDirectoryName + "\\" + name + "BACKUP");
                        File.Copy(pathDirectoryName + "\\SaveGameInfo", pathDirectoryName + "\\" + "SaveGameInfoBACKUP");
                    }

                    // Remplacements
                    await Task.Run(() =>
                    {
                        mOperation.RemplaceDraivin(docName, docGame, comboBox1.Text, buttonReplace);
                    });

                    // Sauvegarde
                    docName.Save(pathfileName);
                    docGame.Save(pathDirectoryName + "\\SaveGameInfo");

                    // Changements tête bouton
                    buttonReplace.Enabled = false;
                    buttonReplace.BackColor = Color.White;
                    buttonReplace.Text = Translate_Terminé();
                    done = true;
                }
                catch
                {
                    buttonReplace.Enabled = false;
                    buttonReplace.BackColor = Color.White;
                    buttonReplace.Text = Translate_Erreur();
                }
            }
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            // Télécharge et exécute la dernière version
            if (hasUpdate)
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://github.com/actionbreaker/SDVFR-Save-Patch/releases/download/" + last + "/SDVFRSavePatch_" + last + ".exe", "SDVFRSavePatch_" + last + ".exe");
                Process.Start("SDVFRSavePatch_" + last + ".exe");
                Dispose();
            }
            // Si pas de MAJ, changelog
            else
            {
                Process.Start("https://github.com/actionbreaker/SDVFR-Save-Patch/releases");
            }
        }

        private void checkBoxBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxBackup.Checked)
            {
                checkBoxBackup.ForeColor = Color.Red;
                mForm2 = new Form2();
                mForm2.Show();
            }
            else
            {
                checkBoxBackup.ForeColor = Color.Black;
                mForm2.Close();
            }
        }

        private async void CheckUpdate()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://github.com/actionbreaker/SDVFR-Save-Patch/releases/latest");
            response.EnsureSuccessStatusCode();
            string responseUri = response.RequestMessage.RequestUri.ToString();
            Uri myUri = new Uri(responseUri);
            string[] pathsegments = myUri.Segments;
            last = pathsegments.Last();

            // MAJ disponible
            if (last != currentVersion)
            {
                hasUpdate = true;
                buttonMAJ.Enabled = true;
                buttonMAJ.BackColor = Color.DarkOrange;
                buttonMAJ.Text = Translate_Téléchargerla() + last;
            }
            // Pas de MAJ
            else
            {
                hasUpdate = false;
                buttonMAJ.Text = "Changelog";
            }
        }

        string Translate_Téléchargerla()
        {
            string laurentromechkoestunoiseau;

            switch (comboBox1.Text)
            {
                case "Français":
                    laurentromechkoestunoiseau = "Télécharger la ";
                    break;
                case "Español":
                    laurentromechkoestunoiseau = "Descargar ";
                    break;
                default:
                    laurentromechkoestunoiseau = "Download ";
                    break;
            }
            return laurentromechkoestunoiseau;
        }

        string Translate_Traduire()
        {
            string laurentromechkoestunoiseau;
            switch (comboBox1.Text)
            {
                case "Français":
                    laurentromechkoestunoiseau = "Traduire";
                    break;
                case "Español":
                    laurentromechkoestunoiseau = "Traducir";
                    break;
                default:
                    laurentromechkoestunoiseau = "Translate";
                    break;
            }
            return laurentromechkoestunoiseau;
        }

        string Translate_Terminé()
        {
            string laurentromechkoestunoiseau;
            switch (comboBox1.Text)
            {
                case "Français":
                    laurentromechkoestunoiseau = "Terminé !";
                    break;
                case "Español":
                    laurentromechkoestunoiseau = "Completar !";
                    break;
                default:
                    laurentromechkoestunoiseau = "Done !";
                    break;
            }
            return laurentromechkoestunoiseau;
        }

        string Translate_Erreur()
        {
            string laurentromechkoestunoiseau;
            switch (comboBox1.Text)
            {
                case "Français":
                    laurentromechkoestunoiseau = "Erreur";
                    break;
                case "Español":
                    laurentromechkoestunoiseau = "Error";
                    break;
                default:
                    laurentromechkoestunoiseau = "Error";
                    break;
            }
            return laurentromechkoestunoiseau;
        }

        string EnCours()
        {
            string laurentromechkoestunoiseau;
            switch (comboBox1.Text)
            {
                case "Français":
                    laurentromechkoestunoiseau = "En cours";
                    break;
                case "Español":
                    laurentromechkoestunoiseau = "En curso";
                    break;
                default:
                    laurentromechkoestunoiseau = "Working";
                    break;
            }
            return laurentromechkoestunoiseau;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Français":
                    if (fileLoaded == false)
                    {
                        buttonLoadSaveName.Text = "Charger \"Nom_12345\"";
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Backup dans le dossier de la save";
                    labelCompWith.Text = "pour v0.30";
                    break;
                case "Español":
                    if (fileLoaded == false)
                    {
                        buttonLoadSaveName.Text = "Cargar \"Name_12345\"";
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Copia de seguridad";
                    labelCompWith.Text = "para v1.4.2";
                    break;
                default:
                    if (fileLoaded == false)
                    {
                        buttonLoadSaveName.Text = "Load \"Name_12345\"";
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Backup in the save's folder";
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://community.playstarbound.com/threads/fan-translation-projects-pt-fr-sp-cz-de.114398/");
        }
    }
}
