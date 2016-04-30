using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TranslationFixer
{
    public partial class Form1 : Form
    {
        XmlDocument docGame;
        XmlDocument docName;

        Fonctions mOperation;
        Form2 mForm2;

        private string pathfileGame;
        private string pathfileName;
        string pathDirectoryGame;
        string pathDirectoryName;
        string game;
        string name;
        string currentVersion = "v0.8.1";

        bool done;
        bool hasUpdate = false;
        string last;

        public Form1()
        {
            InitializeComponent();
            label2.Text = currentVersion;
            done = false;
            mOperation = new Fonctions();
        }

        private void buttonLoadSaveGame_Click(object sender, EventArgs e)   // Charger SaveGameInfo
        {
            // Sélection du fichier
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley\\Saves";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathfileGame = openFileDialog1.FileName;                    // Chemin + Nom fichier
                pathDirectoryGame = Path.GetDirectoryName(pathfileGame);    // Chemin
                game = Path.GetFileNameWithoutExtension(pathfileGame);      // Nom fichier

                try
                {
                    // Chargement du fichier
                    // Bon fichier
                    if (game == "SaveGameInfo")
                    {
                        docGame = new XmlDocument();
                        docGame.Load(pathfileGame);
                        buttonLoadSaveGame.BackColor = Color.LimeGreen;
                        buttonLoadSaveGame.Text = game;
                    }
                    //Erreur
                    else
                    {
                        buttonLoadSaveGame.BackColor = Color.Firebrick;
                        buttonLoadSaveGame.Text = "Mauvais fichier";
                    }
                }
                catch
                {
                    buttonLoadSaveGame.BackColor = Color.Firebrick;
                    buttonLoadSaveGame.Text = "Erreur";
                }
            }
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
                        docName = new XmlDocument();
                        docName.Load(pathfileName);
                        buttonLoadSaveName.BackColor = Color.LimeGreen;
                        buttonLoadSaveName.Text = name;
                    }
                }
                catch
                {
                    buttonLoadSaveName.BackColor = Color.Firebrick;
                    buttonLoadSaveName.Text = "Erreur";
                }
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                try
                {
                    // Backup
                    if (checkBoxBackup.Checked == true)
                    {
                        File.Delete(pathDirectoryName + "\\" + name + "BACKUP");
                        File.Delete(pathDirectoryGame + "\\" + "SaveGameInfoBACKUP");
                        File.Copy(pathfileName, pathDirectoryName + "\\" + name + "BACKUP");
                        File.Copy(pathfileGame, pathDirectoryGame + "\\" + "SaveGameInfoBACKUP");
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
                        docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/objects/item/value/Object/Name"),
                        docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/objects/item/value/Object/name"),

                        // Lieux où chercher (Game)
                        docGame.SelectNodes("/Farmer/items/Item"),
                        docGame.SelectNodes("/Farmer/craftingRecipes/item/key/string"),
                    };

                    // Remplacements
                    for (int i = 0; i < nodeTab.GetLength(0); i++)
                    {
                        mOperation.Remplace3(nodeTab[i]);
                    }

                    // Sauvegarde
                    docName.Save(pathfileName);
                    docGame.Save(pathfileGame);
                    buttonReplace.BackColor = Color.LimeGreen;
                    buttonReplace.Text = "Terminé";
                    done = true;
                }
                catch
                {
                    buttonReplace.Text = "Erreur";
                }
            }
        }

        private async void buttonMAJ_Click(object sender, EventArgs e)
        {
            // Premier passage OU si pas d'update
            if (!hasUpdate)
            {
                buttonMAJ.Text = "Recherche...";
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
                    buttonMAJ.BackColor = Color.DarkOrange;
                    buttonMAJ.Text = "Télécharger la "+ last;
                }
                // Pas de MAJ
                else
                {
                    hasUpdate = false;
                    buttonMAJ.Text = "Aucune mise à jour";
                }
            }
            // Télécharge et exécute la dernière version
            else
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://github.com/actionbreaker/SDVFR-Save-Patch/releases/download/"+last+"/SDVFRSavePatch_"+last+".exe", "SDVFRSavePatch_"+last+".exe");
                Process.Start("SDVFRSavePatch_" + last + ".exe");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/actionbreaker/SDVFR-Save-Patch/releases");
        }
    }
}
