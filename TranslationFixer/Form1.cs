// dev branch version

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TranslationFixer
{
    public partial class Form1 : MaterialForm
    {
        Fonctions mOperation;

        XmlDocument docGame;
        XmlDocument docName;

        private string pathfileName;
        string pathDirectoryName;
        string name;
        string currentVersion = "v0.14";

        bool fileLoaded;
        bool hasUpdate = false;
        string last;
        string[] directories;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley\\Saves");
            int i = 0;

            while (i < directories.GetLength(0))
            {
                comboBoxSave.Items.AddRange(new object[] { Path.GetFileNameWithoutExtension(directories[i]).Trim(new Char[] { '_', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) });
                i++;
            }

            fileLoaded = false;
            mOperation = new Fonctions();

            // Langue par défaut
            comboBoxSave.Text = "Français";

            // Corriger
            buttonReplace.Enabled = false;
            buttonReplace.BackColor = Color.White;
            buttonReplace.Text = "Save Patch " + currentVersion;

            // Recherche de MAJ
            buttonMAJ.Text = "Recherche...";
            CheckUpdate();
        }

        private void comboBoxSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSave.SelectedIndex;
            name = Path.GetFileNameWithoutExtension(directories[index]);
            pathfileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley\\Saves\\" + name + "\\" + name;
            pathDirectoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley\\Saves\\" + name;

            docName = new XmlDocument();
            docName.Load(pathfileName);
            docGame = new XmlDocument();
            docGame.Load(pathDirectoryName + "\\SaveGameInfo");

            // Bouton "Corriger"
            if ((comboBox1.Text != "") && (comboBoxSave.Text != ""))
            {
                buttonReplace.Enabled = true;
                buttonReplace.Font = new Font("Calibri Light", 15F);
                buttonReplace.BackColor = SystemColors.Highlight;
                buttonReplace.Text = Translate_Traduire();
            }
        }

        private async void buttonReplace_Click(object sender, EventArgs el)
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

                XmlNodeList[] nodeTab = new XmlNodeList[]{
                    // Lieux où chercher (Name)
                    docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/items/Item"),
                    docName.SelectNodes("/SaveGame/player/items/Item"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/buildingType"),
                    docName.SelectNodes("/SaveGame/player/craftingRecipes/item/key/string"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/Name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/heldObject/Name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/heldObject/name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/objects/item/value/Object/Name"),
                    docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/objects/item/value/Object/name"),

                    // Lieux où chercher (Game)
                    docGame.SelectNodes("/Farmer/items/Item"),
                    docGame.SelectNodes("/Farmer/craftingRecipes/item/key/string"),
                };

                // Remplacements
                await Task.Run(() =>
                {
                    for (int i = 0; i < nodeTab.GetLength(0); i++)
                    {
                        mOperation.Remplace3(nodeTab[i], comboBox1.Text, buttonReplace);
                    }
                });

                // Sauvegarde
                docName.Save(pathfileName);
                docGame.Save(pathDirectoryName + "\\SaveGameInfo");

                // Changements tête bouton
                buttonReplace.Enabled = false;
                buttonReplace.BackColor = Color.White;
                buttonReplace.Text = Translate_Terminé();
            }
            catch
            {
                buttonReplace.Enabled = false;
                buttonReplace.BackColor = Color.White;
                buttonReplace.Text = Translate_Erreur();
            }
            
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            // Télécharge et exécute la dernière version
            if (hasUpdate)
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://github.com/actionbreaker/SDVSavePatch/releases/download/" + last + "/SDVSavePatch_" + last + ".exe", "SDVSavePatch_" + last + ".exe");
                Process.Start("SDVSavePatch_" + last + ".exe");
                Dispose();
            }
            // Si pas de MAJ, changelog
            else
            {
                Process.Start("https://github.com/actionbreaker/SDVSavePatch/releases");
            }
        }

        private void checkBoxBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxBackup.Checked)
            {
                checkBoxBackup.ForeColor = Color.Red;
            }
            else
            {
                checkBoxBackup.ForeColor = Color.Black;
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
                    laurentromechkoestunoiseau = "Completado !";
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
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Backup dans le dossier de la save";
                    labelCompWith.Text = "pour v0.32";
                    break;
                case "Español":
                    if (fileLoaded == false)
                    {
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Copia de seguridad";
                    labelCompWith.Text = "para v1.4.3";
                    break;
                default:
                    if (fileLoaded == false)
                    {
                    }
                    else
                    {
                        buttonReplace.Text = Translate_Traduire();
                    }
                    checkBoxBackup.Text = "Backup in the save's folder";
                    break;
            }

            // Bouton "Corriger"
            if ((comboBox1.Text != "") && (comboBoxSave.Text != ""))
            {
                buttonReplace.Enabled = true;
                buttonReplace.Font = new Font("Calibri Light", 15F);
                buttonReplace.BackColor = SystemColors.Highlight;
                buttonReplace.Text = Translate_Traduire();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://community.playstarbound.com/threads/fan-translation-projects-pt-fr-sp-cz-de.114398/");
        }

        
    }
}
